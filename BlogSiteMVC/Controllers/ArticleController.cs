using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Read()
        {
            return View();
        }

        public IActionResult WriterDetail()
        {
            return View();
        }
    }
}
