using KitchenFanatics.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Services
{
    //Written by Thomas
    public class LineReadService
    {
        //A list is established, so it can be reffered to from any other place int the program
        public List<ItemType> AllTypes { get; set; }

        //A constructor is created for the ItemType class
        public LineReadService()
        {
            //A cennection to ItemTypeRepository is made
            var itemTypeRepository = new Repositories.ItemTypeRepository();
            //AllTypes is set to include all item types
            AllTypes = itemTypeRepository.GetAllItemTypes();
        }

        /// <summary>
        /// Reads a string while looking for item types
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public List<int> ReadForType(string text)
        {
            //Makes a new list of int named result
            var result = new List<int>();

            //Makes a new string that is the original text but in uppercase
            var Text = text.ToUpper();

            //A foreach that repeats for each type in AllTypes
            foreach (var type in AllTypes)
            {
                //Check if the itemtypes name is in the text
                if (Text.Contains(type.TypeName.ToUpper()) == true)
                {
                    //makes a temp variable, and sets it to hold the itemtype that matches the text
                    var temp = AllTypes.Find(itm => itm.TypeName.ToUpper() == type.TypeName.ToUpper());
                    //adds the itemtypes id to result
                    result.Add(temp.id);
                }
            }

            //returns result
            return result;
        }
    }
}
