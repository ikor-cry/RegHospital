using Microsoft.EntityFrameworkCore;
using RegHospital.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegHospital
{
    public class RegHospitalContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Specialtie> Specialties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RegHospital;Trusted_Connection=True;");
        }
    }
}
