using System.Data.SqlClient;
using CodeJam.Data.Entities;
using Dapper;

namespace CodeJam.Data.Repositories
{
    public interface ISubmissionRepository
    {
        void Insert(Submission submission);
    }

    public class SubmissionRepository : ISubmissionRepository
    {
        public SubmissionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Insert(Submission submission)
        {
            using (var cnn = new SqlConnection(_connectionString))
            {
                cnn.Execute(@"INSERT INTO Submission (ProblemId, EmailAddress)
                              VALUES @ProblemId, @EmailAddress", submission);
            }
        }

        private readonly string _connectionString;
    }
}