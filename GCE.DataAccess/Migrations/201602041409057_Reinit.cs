namespace GCE.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reinit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "MessageId", "dbo.Messages");
            DropIndex("dbo.Messages", "IX_Messages_MessageId");
            DropIndex("dbo.Tickets", new[] { "MessageId" });
            DropPrimaryKey("dbo.Messages");
            AddColumn("dbo.Messages", "CWTiketId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Messages", "MessageId");
            DropColumn("dbo.Messages", "Id");
            DropTable("dbo.Tickets");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Messages", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Messages");
            DropColumn("dbo.Messages", "CWTiketId");
            AddPrimaryKey("dbo.Messages", "Id");
            CreateIndex("dbo.Tickets", "MessageId");
            CreateIndex("dbo.Messages", "MessageId", unique: true, name: "IX_Messages_MessageId");
            AddForeignKey("dbo.Tickets", "MessageId", "dbo.Messages", "Id", cascadeDelete: true);
        }
    }
}
