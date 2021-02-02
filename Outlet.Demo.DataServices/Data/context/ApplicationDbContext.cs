using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Outlet.Demo.DataServices.Data.Entities;
using FluentValidation;



namespace Outlet.Demo.DataServices.Data.context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }
        public DbSet<Entities.Outlet1> Outlets { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(

                new Admin
                { UserId = 1, UserName = "Nimisha", PassWord = "san" }
              );
        }

    }
}