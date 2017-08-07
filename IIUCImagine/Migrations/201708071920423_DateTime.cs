namespace IIUCImagine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memberships", "SubmitDay", c => c.DateTime(nullable: false));
            DropColumn("dbo.Memberships", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Memberships", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Memberships", "SubmitDay");
        }
    }
}
