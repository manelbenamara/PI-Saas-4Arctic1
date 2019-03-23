namespace PMTool_SaaS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToDo1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateBegin = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        DeadLine = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        IsDone = c.Boolean(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoes", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ToDoes", new[] { "User_Id" });
            DropTable("dbo.ToDoes");
        }
    }
}
