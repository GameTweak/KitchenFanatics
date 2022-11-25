using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Models
{
    public class ItemType
    {
        //a constructor is created for the ItemType class, ? allows null
        public ItemType(string typeName, int? uniqueAmount, int id)
        {
            this.TypeName = typeName;
            this.UniqueAmount = uniqueAmount;
            this.id = id;
        }

        //the class is assigned fields, which are all made public 
        public string TypeName { get; set; }
        public int? UniqueAmount { get; set; }
        public int id { get; set; }
    }
}
