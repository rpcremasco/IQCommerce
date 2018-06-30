namespace IQCommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateProducts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products (ProductName, Brand, Description, Price, CategoryId, MainPage, Picture ) VALUES ('Board One', 'Boardeiro', 'High Performance Board', '150.00', 3, 1, 'board1.jpg')");
            Sql("INSERT INTO Products (ProductName, Brand, Description, Price, CategoryId, MainPage, Picture ) VALUES ('Board Two', 'Boardeiro', 'High Performance Board', '175.00', 3, 1, 'board2.jpg')");
            Sql("INSERT INTO Products (ProductName, Brand, Description, Price, CategoryId, MainPage, Picture ) VALUES ('Board Three', 'Boardeiro', 'High Performance Board', '210.00', 3, 1, 'board3.jpg')");
            Sql("INSERT INTO Products (ProductName, Brand, Description, Price, CategoryId, MainPage, Picture ) VALUES ('Board Four', 'Boardeiro', 'High Performance Board', '400.00', 3, 1, 'board4.jpg')");
        }
        
        public override void Down()
        {
        }
    }
}
