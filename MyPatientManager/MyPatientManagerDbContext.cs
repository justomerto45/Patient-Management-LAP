using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using MyPatientManager.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyPatientManager
{
    public class MyPatientManagerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Database=lappentest;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public MyPatientManagerDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Person - Address (1-n)
            modelBuilder.Entity<Person>()
                .HasOne(p => p.Adress)
                .WithMany(a => a.Persons)
                .HasForeignKey(p => p.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            // Treatment - Person (1-n)
            modelBuilder.Entity<Treatment>()
                .HasOne(t => t.Person)
                .WithMany(p => p.Treatments) 
                .HasForeignKey(t => t.PersonId);

            // Treatment - Medis (1-n)
            modelBuilder.Entity<Treatment>()
                .HasMany(t => t.Prescriptions)
                .WithOne(m => m.Treatment)
                .HasForeignKey(m => m.TreatmentId);

            // Article - Medis (1-n)
            modelBuilder.Entity<Medication>()
                .HasMany(a => a.Recipes)
                .WithOne(m => m.Medication)
                .HasForeignKey(m => m.MedicationId)
                .OnDelete(DeleteBehavior.Cascade);


            // Seed data
            modelBuilder.Entity<Adress>().HasData(
                new Adress { Id = 1, Street = "Main Street", HouseNumber = "123", PostalCode = "12345", Country = "Germany" },
                new Adress { Id = 2, Street = "Second Street", HouseNumber = "456", PostalCode = "67890", Country = "Germany" },
                new Adress { Id = 3, Street = "hard bodensee", HouseNumber = "457", PostalCode = "6800", Country = "Austria" }
            );

            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, FName = "John", LName = "Doe", BirthDate = new DateTime(1980, 1, 1), SVN = "1111111111", Phone = "1234567890", Email = "john.doe@example.com", IsUser = true, AddressId = 1 },
                new Person { Id = 2, FName = "Jane", LName = "Doe", BirthDate = new DateTime(1990, 2, 2), SVN = "2222222222", Phone = "0987654321", Email = "jane.doe@example.com", IsUser = false, AddressId = 2 },
                new Person { Id = 3, FName = "Mustafa", LName = "Öztürk", BirthDate = new DateTime(2003, 3, 23), SVN = "1231314134", Phone = "0668494979", Email = "musti.oe@hotmail.com", IsUser = false, AddressId = 3 }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "johndoe",
                    Pw = BCrypt.Net.BCrypt.HashPassword("password")
                });

            modelBuilder.Entity<Treatment>().HasData(
                new Treatment { Id = 1, PersonId = 1, Notes = "Treatment memo", CreatedAt = DateTime.Now },
                new Treatment { Id = 2, PersonId = 2, Notes = "Anschlag auf Kopf", CreatedAt = DateTime.Now },
                new Treatment { Id = 3, PersonId = 3, Notes = "Erkältung", CreatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Medication>().HasData(
                new Medication { Id = 1, Name = "Aspirin", Producer = "Pharma Inc." },
                new Medication { Id = 2, Name = "Ibuprofen", Producer = "MediCorp" },
                new Medication { Id = 3, Name = "Hustensaft", Producer = "Pfizer Inc." }
            );

            modelBuilder.Entity<Prescription>().HasData(
                new Prescription { Id = 1, Amount = 10, TreatmentId = 1, MedicationId = 1 },
                new Prescription { Id = 2, Amount = 20, TreatmentId = 1, MedicationId = 2 },
                new Prescription { Id = 3, Amount = 500, TreatmentId = 1, MedicationId = 3 }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
    }
}
