using Tickets.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace  Subscriptions.Data
{
    public class TicketsDbContext : DbContext
    {
        public TicketsDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Visor> Visors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Subscription>()
                .HasOne<Visor>(t => t.Visor)
                .WithMany(e => e.Subscriptions)
                .HasForeignKey(p => p.VisorId)

            modelBuilder.Entity<Subscription>()
                .HasOne<Team>(t => t.Team)
                .WithMany(e => e.Subscriptions)
                .HasForeignKey(p => p.TeamId);
        }
    }
}