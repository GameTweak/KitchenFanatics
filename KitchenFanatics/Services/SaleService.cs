using KitchenFanatics.Models;
using KitchenFanatics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Services
{
    public class SaleService
    {
        /// <summary>
        /// Returns all Sale Histories on the Sale table
        /// 
        /// Written by Esben
        /// </summary>
        /// <returns></returns>
        public List<SaleHistory> GetSaleHistories()
        {
            SaleRepository saleRepository = new SaleRepository();
            return saleRepository.GetAllSalesV2();
        }
    }
}
