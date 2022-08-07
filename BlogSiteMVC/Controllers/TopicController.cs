using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Controllers
{
    public class TopicController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
