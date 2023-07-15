using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration_System.Views
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        private readonly string _path = @"C:\Users\user'\Desktop\project\patient.db";

        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data source={_path}");

    }
}
