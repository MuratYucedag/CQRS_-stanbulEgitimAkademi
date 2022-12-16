using CQRS_İstanbulEgitimAkademi.CQRS.Results.ProductResults;
using CQRS_İstanbulEgitimAkademi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Handlers.ProductHandlers
{
    public class GetProductQueryHandler2
    {
        private readonly ProductContext _productContext;
        public GetProductQueryHandler2(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public List<GetProductQueryResult2> Handle()
        {
            var values = _productContext.Products.Select(x =>
              new GetProductQueryResult2
              {
                  Name = x.Name,
                  ProductID = x.ProductID,
                  PurchasePrice = int.Parse(x.PurchasePrice.ToString()),
                  SalePrice = int.Parse(x.SalePrice.ToString()),
                  Stock = (int)x.Stock,
                  Tax = (int)x.Tax
              }).ToList();
            return values;
        }
    }
}
