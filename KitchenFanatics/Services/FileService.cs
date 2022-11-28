using KitchenFanatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace KitchenFanatics.Services
{
    public class FileService
    {

        public void CreateFile(List<SaleHistory> sale)
        {
            Word.Application winword = new Word.Application();

            winword.ShowAnimation = false;
            winword.Visible = false;

            object missing = System.Reflection.Missing.Value;

            //Word.Document = winword.Documents.Add(ref missing)
        } 

    }
}
