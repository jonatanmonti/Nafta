namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailVerification : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmailVerifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 64),
                        Code = c.String(nullable: false, maxLength: 10),
                        CreatedAt = c.DateTime(nullable: false),
                        IsVerified = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Users", "IsVerified");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "IsVerified", c => c.Boolean(nullable: false));
            DropTable("dbo.EmailVerifications");
        }
    }
}
