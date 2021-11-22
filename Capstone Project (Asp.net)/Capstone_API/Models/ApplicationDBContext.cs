using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Capstone_API.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<MedicineCategory> MedicineCategory { get; set; }

        public DbSet<Medicine> Medicine { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configuring Connection String.
            optionsBuilder.UseSqlServer("Server=H5CG125CX26;Database=CapstoneProject1;Integrated Security=true");
        }

    }
}