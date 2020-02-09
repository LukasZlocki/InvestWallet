using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvestWallet.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public String StockName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime BuyDate { get; set; }
        public DateTime SaleDate { get; set; }
        public double Sellprice { get; set; }
        public int SellQuantity { get; set; }

    }
}
