﻿using LinkShortnerNew.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinkShortnerNew.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        
    }
}
