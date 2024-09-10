using Asp.NetMvcProjesiPratik.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetMvcProjesiPratik.Controllers
{
    public class CustomerOrderController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 2,
                FirstName = "Hülya",
                LastName = "Koçyiğit",
                Email = "hulyakocyıgıt@gmail.com"
            };
            var orders = new List<Order>
            { 
                new Order {Id = 2,ProductName = "Bodrum Mandalina Kolonyağı",Price = 200,Quantiy = 5 },
                new Order {Id = 3,ProductName = "50 Faktör Güneş Kremi",Price = 175,Quantiy = 2 },
                new Order {Id = 3,ProductName = "Deniz Havlusu",Price = 100,Quantiy = 3 }



            };

            

            var viewmodel = new CustomerOrderViewModel
            {
                Customer = customer,
                
                Orders = orders
            };
            return View(viewmodel);
        }
    }
}
