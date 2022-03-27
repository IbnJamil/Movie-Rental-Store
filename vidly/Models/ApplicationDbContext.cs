using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using vidly.Models;

namespace vidly.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Rental> Rental { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<MemberShipTypes> MemberShipType { get; set; }
        public DbSet<Genre> Genre { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}