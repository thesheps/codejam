using FluentMigrator;

namespace CodeJam.Data.Migrations
{
    [Migration(1)]
    public class CreateProblemTable : Migration
    {
        public override void Up()
        {
            Create.Table("Problem")
                .WithColumn("ProblemId").AsInt32().PrimaryKey("PK_Problem_ProblemId")
                .WithColumn("Code").AsString()
                .WithColumn("Answer").AsString();
        }

        public override void Down()
        {
            Delete.Table("Problem");
        }
    }
}