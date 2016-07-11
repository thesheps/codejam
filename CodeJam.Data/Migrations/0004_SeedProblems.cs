using CodeJam.Data.Entities;
using FluentMigrator;
using Newtonsoft.Json;

namespace CodeJam.Data.Migrations
{
    [Migration(4)]
    public class SeedProblems1 : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Problem").Row(JsonConvert.DeserializeObject<Problem>(Problems.ProblemOne));
        }

        public override void Down()
        {
            Delete.FromTable("Problem");
        }
    }
}