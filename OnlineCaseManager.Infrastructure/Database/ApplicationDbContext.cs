using Microsoft.EntityFrameworkCore;
using OnlineCaseManager.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCaseManager.Infrastructure.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Case>()
                .HasOne(c => c.Lawyer)
                .WithMany()
                .HasForeignKey(c => c.LawyerID)
                .OnDelete(DeleteBehavior.Restrict); // To avoid cascade delete issues

            modelBuilder.Entity<Case>()
                .HasOne(c => c.Client)
                .WithMany()
                .HasForeignKey(c => c.ClientID)
                .OnDelete(DeleteBehavior.Restrict); // Avoid cascade delete
        }

    }
}
