﻿using ASP_Intro.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Intro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
