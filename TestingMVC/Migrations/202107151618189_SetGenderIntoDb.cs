namespace TestingMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetGenderIntoDb : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genders (Id, Name) VALUES (1, 'Male')");
            Sql("INSERT INTO Genders (Id, Name) VALUES (2, 'Female')");
        }
        
        public override void Down()
        {
        }
    }
}
