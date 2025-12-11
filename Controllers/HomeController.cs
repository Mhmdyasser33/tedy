using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using WebApplication1.Models;
using System.Net;
using System.Net.Mail;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult calculate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult calculate(int hours, bool weekend)
        {
            int a, b, c, t;
            a = hours; // number of hours
            b = 10;

            if (weekend == true) // weekend
            {
                c = a * 20;
            }

            if (a <= 8)
            {
                c = a * b;
            }
            else
            {
                c = 8 * b + (a - 8) * 15;
            }

            c = c + tax(c);

            ViewData["Message"] = "your salary is " + c;
            return View();
        }

        int tax(int x)
        {
            int t = x / 100 * 10;
            return t;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public void example()
        {
            int kk = 0;
            int hh;
            kk++;
            hh = f1(kk + 3);
            string lab1 = Convert.ToString(hh);
        }
        int f1(int x)
        {
            x++;
            return x * 2;

        }


    }



}
