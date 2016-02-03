namespace GCE.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageId = c.String(nullable: false, maxLength: 256),
                        PrimaryId = c.String(nullable: false, maxLength: 256),
                        Status = c.Int(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.MessageId, unique: true, name: "IX_Messages_MessageId")
                .Index(t => t.PrimaryId, name: "IX_Messages_PrimaryId");
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageId = c.Int(nullable: false),
                        CWTiketId = c.Int(nullable: false),
                        TikcketJoinType = c.Int(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Messages", t => t.MessageId, cascadeDelete: true)
                .Index(t => t.MessageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "MessageId", "dbo.Messages");
            DropIndex("dbo.Tickets", new[] { "MessageId" });
            DropIndex("dbo.Messages", "IX_Messages_PrimaryId");
            DropIndex("dbo.Messages", "IX_Messages_MessageId");
            DropTable("dbo.Tickets");
            DropTable("dbo.Messages");
        }
    }
}
