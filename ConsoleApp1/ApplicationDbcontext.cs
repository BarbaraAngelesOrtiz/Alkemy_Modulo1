using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp1
{
    internal class ApplicationDbcontext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=EMA\emare;Initial Catalog=EMA\PEPPER;Integrated Security=True")
                      .EnableSensitiveDataLogging(true)
                      .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }            

     public DbSet <Usuario> Usuarios { get; set; }
     public DbSet <Posts> Posts { get; set; }
     public DbSet<Comments> Comments { get; set; }

    }
}
