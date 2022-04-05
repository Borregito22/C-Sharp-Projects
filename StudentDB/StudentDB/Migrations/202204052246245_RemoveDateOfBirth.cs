namespace StudentDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDateOfBirth : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "DateOfBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
