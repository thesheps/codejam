using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using CodeJam.Data.Entities;
using Dapper;

namespace CodeJam.Data.Repositories
{
    public interface IProblemRepository
    {
        IList<Problem> All();
        Problem GetById(int problemId);
    }

    public class ProblemRepository : IProblemRepository
    {
        public ProblemRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<Problem> All()
        {
            using (var cnn = new SqlConnection(_connectionString))
            {
                return cnn.Query<Problem>("SELECT * FROM Problem").ToList();
            }
        }

        public Problem GetById(int problemId)
        {
            using (var cnn = new SqlConnection(_connectionString))
            {
                return cnn.Query<Problem>("SELECT * FROM Problem WHERE ProblemId = @ProblemId", new { problemId }).SingleOrDefault();
            }
        }

        private readonly string _connectionString;
    }
}