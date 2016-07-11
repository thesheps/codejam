namespace CodeJam.Data.Entities
{
    public class Submission
    {
        public int SubmissionId { get; set; }
        public int ProblemId { get; set; }
        public int UserId { get; set; }
        public string Answer { get; set; } 
    }
}