using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMVC.model;
using System.Data;
using Npgsql;
using Dapper;


namespace CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        const string connectionStr = "User ID=postgres;Password=1qaz@WSX;Host=db;Port=5432;Database=product;Pooling=true";
        public IActionResult Index()
        {
            try
            {
                using (var cn = new NpgsqlConnection(connectionStr))
                {
                    var list = cn.Query<Customer>("select * from customer");
                    foreach (var item in list)
                    {
                        Console.Write(item.ToString());
                    }
                    ViewBag.customers = list;
                    return View();
                    //ViewData["customer"] =.ToList();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
