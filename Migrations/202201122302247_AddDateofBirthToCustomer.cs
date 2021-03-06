namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateofBirthToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
