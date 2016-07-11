using FluentMigrator;

namespace CodeJam.Data.Migrations
{
    [Migration(3)]
    public class CreateSubmissionTable : Migration
    {
        public override void Up()
        {
            Create.Table("Submission")
                .WithColumn("SubmissionId").AsInt32().PrimaryKey("PK_Submission_SubmissionId")
                .WithColumn("ProblemId").AsInt32().ForeignKey("Problem", "ProblemId")
                .WithColumn("UserId").AsInt32().ForeignKey("User", "UserId")
                .WithColumn("Answer").AsString();
        }

        public override void Down()
        {
            Delete.Table("Submission");
        }
    }
}