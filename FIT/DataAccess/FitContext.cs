﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class FitContext : DbContext
    {

        public FitContext()
            : base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=SmartHomeDb;Integrated Security=True")
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<DetailAllocation> DetailAllocations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Representative> Representatives { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceBooking> ResourceBookings { get; set; }



        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    modelBuilder.Entity<Course>()
        //        .HasMany(c => c.Instructors).WithMany(i => i.Courses)
        //        .Map(t => t.MapLeftKey("CourseID")
        //            .MapRightKey("PersonID")
        //            .ToTable("CourseInstructor"));
        //}
    }
}
