using HospitalManagmentSystem_LevelArchitecture.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem_LevelArchitecture
{
    public class DoctorDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AEOLTE6;Initial Catalog=HospitalMSDB;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Doctor> Doctors { get; set; }


    }
}
