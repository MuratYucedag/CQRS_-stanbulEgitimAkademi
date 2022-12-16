using CQRS_İstanbulEgitimAkademi.CQRS.Handlers.ProductHandlers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi.Controllers
{
    public class ProductController : Controller
    {

        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly GetProductQueryHandler2 _getProductQueryHandler2;

        public ProductController(GetProductQueryHandler getProductQueryHandler, GetProductQueryHandler2 getProductQueryHandler2)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _getProductQueryHandler2 = getProductQueryHandler2;
        }

        //Depocuya Göre Veri Listesi
        public IActionResult StoragerIndex()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        public IActionResult AccounterIndex()
        {
            var values = _getProductQueryHandler2.Handle();
            return View(values);
        }
    }
}
