using KitchenFanatics.Models;
using KitchenFanatics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenFanatics.Services
{
    // Written by Esben
    public class SaleService
    {
        /// <summary>
        /// Returns all Sale Histories on the Sale table
        /// </summary>
        /// <returns></returns>
        public List<SaleHistory> GetSaleHistories()
        {
            SaleRepository saleRepository = new SaleRepository();
            return saleRepository.GetAllSales();
        }

        /// <summary>
        /// Removes the selected entry from the database
        /// </summary>
        /// <param name="history">Entry to be deleted</param>
        public void DeleteEntry(SaleHistory history)
        {
            SaleRepository saleRepository = new SaleRepository();
            saleRepository.DeleteSelectedSale(history);
        }

        /// <summary>
        /// Creates a new entry and submits it to the database
        /// </summary>
        /// <param name="history"></param>
        public void CreateEntry(SaleHistory history)
        {
            SaleRepository saleRepository = new SaleRepository();
            saleRepository.CreateNewSale(history);
        }

        /// <summary>
        /// Edits an already excisting sale
        /// </summary>
        /// <param name="history">Sale history to edit</param>
        public void EditSale(SaleHistory history)
        {
            SaleRepository saleRepository = new SaleRepository();
            saleRepository.EditSale(history);
        }
    }
}
