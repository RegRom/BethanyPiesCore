﻿using Microsoft.EntityFrameworkCore;

namespace BethanyPies.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        
    }
}