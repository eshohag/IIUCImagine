namespace IIUCImagine.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SubmitDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memberships", "SubmitDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Memberships", "SubmitDay");
        }

        public override void Down()
        {
            AddColumn("dbo.Memberships", "SubmitDay", c => c.DateTime(nullable: false));
            DropColumn("dbo.Memberships", "SubmitDate");
        }
    }
}
