namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 20)");

            //Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
            //Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2");
            //Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE Id = 3");
            //Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE Id = 4");


            //Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            //Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Thriller')");
            //Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            //Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            //Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
