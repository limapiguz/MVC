using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
    }
    public class TestController : Controller
    {
            public Customer GetCustomer()
            {
                Customer c = new Customer();
                c.CustomerName = "Customer1";
                c.Address = "Address1"; 
                return c;
        }

    }
}