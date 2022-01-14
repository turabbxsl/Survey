using Inmigration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inmigration.Context
{
    public class AppContext : DbContext
    {

        public AppContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=InMirration; integrated security=true;");
        }



        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Question2> Questions2 { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Answer2> Answers2 { get; set; }
    }




}
