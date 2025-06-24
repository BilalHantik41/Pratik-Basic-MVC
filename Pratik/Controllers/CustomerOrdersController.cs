using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pratik.Models;
using Pratik.ViewModels;
using Pratik.Models;
using Pratik.ViewModels;

namespace YourProjectName.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // — Örnek müşteri —
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ayşe",
                LastName = "Yılmaz",
                Email = "ayse.yilmaz@example.com"
            };

            // — Örnek siparişler —
            var orders = new List<Order>
            {
                new Order { Id = 101, ProductName = "Kablosuz Mouse",  Price = 79.90m, Quantity = 2 },
                new Order { Id = 102, ProductName = "Mekanik Klavye",  Price = 249.50m, Quantity = 1 },
                new Order { Id = 103, ProductName = "USB-C Adaptör",   Price = 39.99m, Quantity = 3 }
            };

            // ViewModel’i oluştur ve View’a gönder
            var vm = new CustomerOrderViewModel(customer, orders);
            return View(vm);
        }
    }
}
