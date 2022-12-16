using CQRS_İstanbulEgitimAkademi.CQRS.Results.ProductResults;
using CQRS_İstanbulEgitimAkademi.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.CQRS.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly ProductContext _productContext;
        public GetProductQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x =>
            new GetProductQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Shelf = x.Shelf,
                Stock = int.Parse(x.Stock.ToString()),
                Storage = x.Storage
            }).ToList();
            return values;
        }
    }
}
