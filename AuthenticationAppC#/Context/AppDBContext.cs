﻿using AuthenticationAppC_.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAppC_.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<User>().ToTable("users");
        }
    }
}
