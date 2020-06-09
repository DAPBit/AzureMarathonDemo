using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp_OpenIDConnect_DotNet.Models;

namespace WebApp_OpenIDConnect_DotNet.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";


            try
            {
                //Microsoft.AspNetCore.Authentication.AuthenticationOptions ops = new AuthenticationOptions();
                //using (PrincipalContext<ops> context = new PrincipalContext(ContextType.Domain, "praveenazhotmail.onmicrosoft.com", "web@praveenazhotmail.onmicrosoft.com", "ZAQ@112233"))
                //{
                //    if (context.ValidateCredentials("web@praveenazhotmail.onmicrosoft.com", "ZAQ@112233"))
                //    {

                //    }
                //}
            }
            catch (Exception)
            {
            }


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
