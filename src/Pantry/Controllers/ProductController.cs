using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Pantry.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/Product/2
        public IActionResult Recent(int id)
        {
            return View();
        }

        // GET: /<controller>/Product/3
        public IActionResult ProductByCategory(int id)
        {
            return View();
        }

        // GET: /<controller>/Product/5
        public IActionResult Item(int id)
        {
            return View();
        }
    }
}
