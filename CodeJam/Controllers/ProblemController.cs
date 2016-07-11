using System.Configuration;
using System.Web.Mvc;
using CodeJam.Data.Repositories;
using CodeJam.Mappers;
using CodeJam.Models;

namespace CodeJam.Controllers
{
    public class ProblemController : Controller
    {
        public ProblemController()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CodeJam"].ConnectionString;
            _problemRepository = new ProblemRepository(connectionString);
        }

        public ActionResult Index()
        {
            var problems = _problemRepository.All();
            return View(problems[0].ToModel());
        }

        public ActionResult Solve(SolutionModel model)
        {
            return Json(true);
        }

        private readonly IProblemRepository _problemRepository;
    }
}