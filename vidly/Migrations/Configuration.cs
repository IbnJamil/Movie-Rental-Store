using vidly.Models;
namespace vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<vidly.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(vidly.Models.ApplicationDbContext context)
        {
           context.MemberShipType.AddOrUpdate(
                new MemberShipTypes {Id=MemberShip.trial,DiscountRate = 0, DurationInMonths = 0, SignUpFee = 0, MemberShipCatagory = "15 Days Trial" },
                new MemberShipTypes { Id = MemberShip.Basic, DiscountRate = 10, DurationInMonths = 1, SignUpFee = 30, MemberShipCatagory = "Basic" },
                new MemberShipTypes { Id = MemberShip.Silver,DiscountRate = 15, DurationInMonths = 3, SignUpFee = 90, MemberShipCatagory = "Silver" },
                new MemberShipTypes { Id = MemberShip.Gold,DiscountRate = 20, DurationInMonths = 12, SignUpFee = 300, MemberShipCatagory = "Gold" }
                );
           
            context.Genre.AddOrUpdate(
                
                new Genre {Id=movieEnum.Comedy, GenreName="Comedy"},
                new Genre { Id = movieEnum.Action, GenreName = "Action" },
                new Genre { Id = movieEnum.Thriller,GenreName = "Thriller" },
                new Genre { Id = movieEnum.Romance,GenreName = "Romance" },
                new Genre { Id = movieEnum.Entertainment, GenreName = "Entertainment" },
                new Genre { Id = movieEnum.Season,GenreName = "Season" },
                new Genre { Id = movieEnum.Series,GenreName = "Series" },
                new Genre { Id = movieEnum.Drama,GenreName = "Drama" }
                );
        }
    }
}
