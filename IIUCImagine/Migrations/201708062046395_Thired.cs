namespace IIUCImagine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Thired : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tittle = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.MembershipRegis", "ParticipateID", c => c.Int(nullable: false));
            CreateIndex("dbo.MembershipRegis", "ParticipateID");
            AddForeignKey("dbo.MembershipRegis", "ParticipateID", "dbo.Participates", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MembershipRegis", "ParticipateID", "dbo.Participates");
            DropIndex("dbo.MembershipRegis", new[] { "ParticipateID" });
            DropColumn("dbo.MembershipRegis", "ParticipateID");
            DropTable("dbo.Participates");
        }
    }
}
