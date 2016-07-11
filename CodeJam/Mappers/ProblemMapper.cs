using CodeJam.Data.Entities;
using CodeJam.Models;

namespace CodeJam.Mappers
{
    public static class ProblemMapper
    {
        public static ProblemModel ToModel(this Problem problem)
        {
            return new ProblemModel
            {
                Answer = problem.Answer,
                Code = problem.Code,
                ProblemId = problem.ProblemId
            };
        }
    }
}