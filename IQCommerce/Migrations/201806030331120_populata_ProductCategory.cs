namespace IQCommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populata_ProductCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ProductCategories (Name) VALUES ('Sports')");
        }
        
        public override void Down()
        {
        }
    }
}
