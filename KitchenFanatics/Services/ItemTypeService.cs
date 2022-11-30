using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Services
{
    public class ItemTypeService
    {
        Repositories.ItemTypeRepository ItemTypesRepository = new Repositories.ItemTypeRepository();

        /// <summary>
        /// Retrives a method from the ItemTypeRepository, which puts all Itemtypes from the database into a list
        /// </summary>
        /// <returns></returns>
        public List<Models.ItemType> GetAllItemTypes()
        {
            return ItemTypesRepository.GetAllItemTypes();
        }
    }
}
