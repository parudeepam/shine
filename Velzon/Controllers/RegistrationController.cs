using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using Velzon.Models;

namespace Velzon.Controllers
{
    public class RegistrationController : Controller
    {
        [ActionName("Registration")]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Registration obj)
        {
            string JSONResult=JsonConvert.SerializeObject(obj);
            string path = @"json\\employee.json";
            System.IO.File.WriteAllText(path + "output.json", JSONResult);                       
            TempData["msg"] = "Json file Generated! check this in your App_Data folder";
            return RedirectToAction("Registration"); ;
            //return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
