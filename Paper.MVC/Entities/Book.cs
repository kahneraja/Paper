using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Paper.MVC
{
    public class PaperContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=localhost; Initial Catalog=PaperDB; Persist Security Info=True; User ID=SA; Password=<YourStrong!Passw0rd>;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string Url { get; set; }

        public string Title { get; set; }
    }

}