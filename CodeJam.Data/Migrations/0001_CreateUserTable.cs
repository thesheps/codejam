using FluentMigrator;

namespace CodeJam.Data.Migrations
{
    [Migration(1)]
    public class CreateUserTable : Migration
    {
        public override void Up()
        {
            Create.Table("User")
                .WithColumn("UserId").AsInt32().PrimaryKey("PK_User_UserId")
                .WithColumn("EmailAddress").AsString();
        }

        public override void Down()
        {
            Delete.Table("User");
        }
    }
}