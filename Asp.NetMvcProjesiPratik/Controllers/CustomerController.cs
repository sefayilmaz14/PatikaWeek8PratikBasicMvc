﻿using Asp.NetMvcProjesiPratik.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetMvcProjesiPratik.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            // Basit bir model örneği oluşturuyoruz
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            // ViewModel oluşturup view'a gönderiyoruz
            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                WelcomeMessage = "Welcome to our customer portal!"
            };

            return View(viewModel);
        }
    }

}
