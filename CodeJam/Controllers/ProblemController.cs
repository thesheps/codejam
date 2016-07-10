using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using CodeJam.Models;

namespace CodeJam.Controllers
{
    public class ProblemController : Controller
    {
        public ActionResult Index()
        {
            var files = Directory.GetFiles(HttpContext.Server.MapPath("Problems"));
            var i = new Random().Next(files.Count() - 1);
            var problem = new ProblemModel
            {
                Code = System.IO.File.ReadAllText(files[i])
            };

            return View(problem);
        }
    }
}