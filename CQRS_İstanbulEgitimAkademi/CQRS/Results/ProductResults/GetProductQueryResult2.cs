using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Results.ProductResults
{
    public class GetProductQueryResult2
    {
        //Muhasebeci İçin Veri Getirme Alanı
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Tax { get; set; }
    }
}
