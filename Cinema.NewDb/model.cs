using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CinemaApp.NewDb
{
    public class CinemaContext : DbContext
    {
        public DbSet<Cinematbl> Cinemas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.CinemaApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Cinematbl
    {
        [Key]
        public int CinemaId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}