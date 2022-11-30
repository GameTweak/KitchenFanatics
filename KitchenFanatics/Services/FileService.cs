using KitchenFanatics.Models;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Word = Microsoft.Office.Interop.Word;

namespace KitchenFanatics.Services
{
    /// <summary>
    /// FileService is for printing out the Sale stats file
    /// 
    /// By Esben
    /// </summary>
    public class FileService
    {
        /// <summary>
        /// The method used to create a new Sale stat file
        /// </summary>
        /// <param name="sale">The sales to include in the file</param>
        /// <param name="start">From date</param>
        /// <param name="end">Till date</param>
        public void CreateFile(List<SaleHistory> sale, DateTime start, DateTime end)
        {
            // The string for where the file is being stored aswell as its name
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Salgsstatistik[{DateTime.Now.ToString("MM-dd-yyyy HH:mm")}].pdf");

            // Creates an instance for the Word Application
            Word.Application win = new Word.Application();

            // Disableds word animation
            win.ShowAnimation = false;

            // Hides the word application
            win.Visible = false;

            // Creates a new document
            Document document = win.Documents.Add();

            // Creates an new paragraphs on the page
            Paragraph body = document.Paragraphs.Add();
            
            // Fetches the Heading style 1
            object styleHeading1 = "Heading 1";

            // Sets the style of the paragraph
            body.Range.set_Style(ref styleHeading1);

            // Writes the header text
            body.Range.Text = $"Salgsstatistik {DateTime.Now.Year}       Fra dato:{start.ToString("MM/dd/yyyy")} Til dato:{end.ToString("MM/dd/yyyy")}";
            
            // Jumps to the next line
            body.Range.InsertParagraphAfter();

            // Defines a new table object on the page
            Table table = document.Tables.Add(body.Range, sale.Count() + 1, 4);

            // Defining the header values in the table
            table.Cell(1, 1).Range.Text = "ID";
            table.Cell(1, 2).Range.Text = "Navn";
            table.Cell(1, 3).Range.Text = "Dato";
            table.Cell(1, 4).Range.Text = "Pris";

            // Specifies that it starts on row 2
            int row = 2;

            // Loops through each SaleHistory and adds it to the table
            foreach (SaleHistory saleHistory in sale.OrderBy(s => s.SaleDate))
            {
                // Inserts the data from the SaleHistory 
                table.Cell(row, 1).Range.Text = $"{saleHistory.Id}";
                table.Cell(row, 2).Range.Text = $"{saleHistory.Customer.FullName}";
                table.Cell(row, 3).Range.Text = $"{saleHistory.SaleDate.ToShortDateString()}";
                table.Cell(row, 4).Range.Text = $"{saleHistory.TotalPrice} ,-";
                
                // Increase row count
                row++;
            }

            // Jumps to the next paragraph
            body.Range.InsertParagraphAfter();

            // Inserts text telling the total sum of the SaleHistory
            body.Range.Text = $"I alt kr.    {sale.Select(s => s.TotalPrice).Sum()} ,-";

            // Checks if the file exists
            if (File.Exists(path))
            {
                // Informs the user that the file aready exists and awaits for a Yes/No result
                DialogResult dialog = MessageBox.Show("A file with that name already exists, do you wish to override?", "File already exist!", MessageBoxButtons.YesNo);
                
                // Condition checks if it is yes
                if (dialog == DialogResult.Yes)
                    // Deletes the file
                    File.Delete(path);
                else 
                    // Cancels the method
                    return;
            }

            // Saves the document as a PDF
            document.SaveAs2(path, WdSaveFormat.wdFormatPDF);

            // Prevents word for making a prompt to save
            document.Saved = true;

            // Closes document
            document.Close();

            // Exits word
            win.Quit();
        }
    }
}
