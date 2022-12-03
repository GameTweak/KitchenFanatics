using KitchenFanatics.Models;
using KitchenFanatics.Services;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenFanatics.Forms
{
    //Written by Thomas
    public partial class Intellectual_Counceling : Form
    {
        // makes a series of variables that i am going use later in the code
        public int QuestionNumber { get; set; }
        public Models.Filter CurrentFilter { get; set; }
        // ValidDecimal is used when checking wether or not a string can be converted to a decimal
        public bool ValidDecimal { get; set; }
        // A connection to the logService
        LogService logger = new LogService();
        /// <summary>
        /// A constructer that starts when the form is innitialized
        /// </summary>
        public Intellectual_Counceling()
        {
            InitializeComponent();

            try
            {
                // Sets QuestionNumber to 0 (the first question)
                QuestionNumber = 0;

                // Sets the default values for CurrentFilter
                CurrentFilter = new Filter("",null,null,null,null,null,null,null,null,null);

                SetCheckBoxList();

                // Calls the method SelectQuestion
                SelectQuestion();
            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }

        }

        /// <summary>
        /// Sets up the values in the checkBoxList
        /// </summary>
        private void SetCheckBoxList()
        {
            // Makes a connection to the ItemTypeService
            var itemTypeService = new ItemTypeService();

            // Gets all item types
            var choices = itemTypeService.GetAllItemTypes();

            // Adds all item types as choices in CLB_types
            foreach(var choice in choices)
            {
                CLB_type.Items.Add(choice.TypeName);
            }

            // Makes it so a box in the checkBoxList is checked after one click, instead of the default doubleclick
            CLB_type.CheckOnClick = true;
        }

        /// <summary>
        /// Sets the UI to match the currently chosen question
        /// </summary>
        private void SelectQuestion()
        {
            // A switch that checks what number question is the current one
            switch (QuestionNumber)
            {
                case 0:
                    QuestionType();
                    break;

                case 1:
                    QuestionSize();
                    break;

                case 2:
                    QuestionWeight();
                    break;

                case 3:
                    QuestionPrice();
                    break;

                case 4:
                    // When all questions have been answered, sets dialogresult to OK so the data can be taken to another form
                    // And then closes the form
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Submits the data for the current question
        /// </summary>
        private void Submit()
        {
            // A switch that checks what number question is being worked with
            switch (QuestionNumber)
            {
                case 0:
                    ValidDecimal = true;
                    // Checks whether or not any boxes have been marked in CLB_type
                    if (CLB_type.CheckedItems.Count != 0)
                    {
                        // Makes a new string
                        string result = "";

                        // Adds each chosen box to the string result
                        foreach (var item in CLB_type.CheckedItems)
                        {
                            result = result + item.ToString() + ", ";
                        }
                        // Saves the input into the current filter
                        CurrentFilter.Type = result;
                    }
                    break;

                case 1:
                    ValidDecimal = true;
                    // Uses the method CheckTryParseStringToDecimal to save each values data into the current filter
                    CurrentFilter.MaxHeight = CheckTryParseStringToDecimal("Max højde", txt_number1.Text);
                    CurrentFilter.MaxWidth = CheckTryParseStringToDecimal("Max bredde", txt_number2.Text);
                    CurrentFilter.MaxDepth = CheckTryParseStringToDecimal("Max dybde", txt_number3.Text);
                    CurrentFilter.MinHeight = CheckTryParseStringToDecimal("Min højde", txt_number4.Text);
                    CurrentFilter.MinWidth = CheckTryParseStringToDecimal("Min bredde", txt_number5.Text);
                    CurrentFilter.MinDepth = CheckTryParseStringToDecimal("Min dybde", txt_number6.Text);
                    break;

                case 2:
                    ValidDecimal = true;
                    CurrentFilter.MaxWeight = CheckTryParseStringToDecimal("Max vægt", txt_number1.Text);
                    break;

                case 3:
                    ValidDecimal = true;
                    CurrentFilter.MaxPrice = CheckTryParseStringToDecimal("Max pris", txt_number1.Text);
                    CurrentFilter.MinPrice = CheckTryParseStringToDecimal("Min pris", txt_number2.Text);
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Sets the UI for the question about type
        /// </summary>
        private void QuestionType()
        {
            ClearUI();
            lb_question.Text = "Hvilken type/typer produkter leder du efter";

            CLB_type.Visible = true;
        }

        /// <summary>
        /// Sets the UI for the question about size
        /// </summary>
        private void QuestionSize()
        {
            ClearUI();
            lb_question.Text = "Hvilke størrelse ønsker du";

            txt_number1.Visible = true;
            txt_number2.Visible = true;
            txt_number3.Visible = true;
            txt_number4.Visible = true;
            txt_number5.Visible = true;
            txt_number6.Visible = true;
            lb_number1.Visible = true;
            lb_number2.Visible = true;
            lb_number3.Visible = true;
            lb_number4.Visible = true;
            lb_number5.Visible = true;

            lb_number1.Text = "Højde";
            lb_number2.Text = "Bredde";
            lb_number3.Text = "Dybde";
        }

        /// <summary>
        /// Sets the UI for the question about wheight
        /// </summary>
        private void QuestionWeight()
        {
            ClearUI();
            lb_question.Text = "Hvor tung må produktet være";

            txt_number1.Visible = true;
            lb_number1.Visible = true;

            lb_number1.Text = "Max vægt";
        }

        /// <summary>
        /// Sets the UI for the question about price
        /// </summary>
        private void QuestionPrice()
        {
            ClearUI();
            lb_question.Text = "Hvilken prisklasse leder du efter";

            txt_number1.Visible = true;
            txt_number2.Visible = true;
            lb_number1.Visible = true;
            lb_number2.Visible = true;

            lb_number1.Text = "Max pris";
            lb_number2.Text = "Min pris";
        }

        /// <summary>
        /// When cancel is clicked, closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sets what happens when one clicks on the submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Calls the submit method
                Submit();

                // Checks whether or not the convertion to decimal is valid, if it is then the program proceeds to next question
                if (ValidDecimal == true)
                {
                    QuestionNumber++;
                    SelectQuestion();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }
            
        }

        /// <summary>
        /// Skips the question when skip is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_skip_Click(object sender, EventArgs e)
        {
            try
            {
                QuestionNumber++;
                SelectQuestion();
            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }

        }

        /// <summary>
        /// Limits the text inputs where numbers have to be inserted, so (almost) only numbers can be inserted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Clears the UI
        /// </summary>
        private void ClearUI()
        {
            txt_number1.Visible = false;
            txt_number2.Visible = false;
            txt_number3.Visible = false;
            txt_number4.Visible = false;
            txt_number5.Visible = false;
            txt_number6.Visible = false;
            lb_number1.Visible = false;
            lb_number2.Visible = false;
            lb_number3.Visible = false;
            lb_number4.Visible = false;
            lb_number5.Visible = false;
            CLB_type.Visible = false;

            txt_number1.Text = "";
            txt_number2.Text = "";
            txt_number3.Text = "";
            txt_number4.Text = "";
            txt_number5.Text = "";
            txt_number6.Text = "";
        }

        /// <summary>
        /// Checks whether or not a string can be converted into a valid decimal
        /// </summary>
        /// <param name="varName"></param>
        /// <param name="from"></param>
        /// <returns></returns>
        private decimal? CheckTryParseStringToDecimal(string varName, string from)
        {
            // Checks that something has been written into the text, if not then return null
            if (from == "")
            {
                return null;
            }
            // Checks that the string can be converted into a valid decimal, if yes, then returns that decimal
            else if (decimal.TryParse(from, out decimal filler) && Convert.ToDecimal(from) > 0)
            {
                return Convert.ToDecimal(from);
            }
            // Checks wether or not the string can be converted into a negative decimal, if yes, then tell the user the decimal has to be possitive,
            // sets ValidDecimal to false, and returns null
            else if (decimal.TryParse(from, out decimal filler2) && Convert.ToDecimal(from) < 0)
            {
                MessageBox.Show(varName + " kan ikke være negativ");
                ValidDecimal = false;
                return null;
            }
            // The code will only end up here if some other problem occoured, it will tell the user the string could not be converted, set
            // ValidDecimal to false, and return null
            else
            {
                MessageBox.Show(varName + " kunne ikke konverteres til et decimaltal");
                ValidDecimal = false;
                return null;
            }
        }
        
        /// <summary>
        /// Går et spørgsmål tilbage når man trykker på back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                // tjekker at det ikke allerede er det første spørgsmål
                if (QuestionNumber > 0)
                {
                    QuestionNumber--;
                    SelectQuestion();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex);
            }
        }
    }
}
