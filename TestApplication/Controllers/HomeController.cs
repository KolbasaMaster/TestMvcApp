using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanyService _service;

        public HomeController()
        {
            _service = new CompanyService();
        }
        public async Task<ActionResult> Index(string inn)
        {
          return View();
        }
        public ActionResult GetResult(string inn)
        {
            var res = _service.GetResult(inn);
            return View(res);
        }
    }
}