using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Results.ProductResults
{
    public class GetProductQueryResult
    {
        //Depocu İçin Veri Getirme Alanı
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Storage { get; set; }
        public string Shelf { get; set; }
    }
}
