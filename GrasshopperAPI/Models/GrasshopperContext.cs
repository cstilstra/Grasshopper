using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GrasshopperAPI.Models
{
    public class GrasshopperContext : DbContext
    {
        public DbSet<Grasshopper> Grasshoppers { get; set; }
        public DbSet<Sensei> Senseis { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        public GrasshopperContext(DbContextOptions<GrasshopperContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lesson>()
                .HasKey(k => new { k.GrasshopperId, k.SenseiId, k.MeetingTime });
        }
    }
}
