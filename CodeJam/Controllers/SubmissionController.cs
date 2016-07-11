using System.Configuration;
using System.Web.Mvc;
using CodeJam.Data.Repositories;
using CodeJam.Models;

namespace CodeJam.Controllers
{
    public class SubmissionController : Controller
    {
        public SubmissionController()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CodeJam"].ConnectionString;
            _submissionRepository = new SubmissionRepository(connectionString);
            _problemRepository = new ProblemRepository(connectionString);
        }

        public ActionResult Solve(SubmissionModel model)
        {
            var problem = _problemRepository.GetById(model.ProblemId);

            return Json(problem.Answer == model.Answer);
        }

        private SubmissionRepository _submissionRepository;
        private readonly ProblemRepository _problemRepository;
    }
}