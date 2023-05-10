using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public class Context: DbContext
    {
        public Context():base (@"Data source=.;Initial catalog= EFProject;Integrated Security=True")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImportPermitItem>()
            .HasRequired(x => x.ImportPermit)
            .WithMany(x => x.Items)
            .HasForeignKey(x => x.ImportPermitId)
            .WillCascadeOnDelete(false);

           modelBuilder.Entity<ExchangePermitItem>()
           .HasRequired(x => x.ExchangePermit)
           .WithMany(x => x.Items)
           .HasForeignKey(x => x.ExchangePermitId)
           .WillCascadeOnDelete(false);

             modelBuilder.Entity<TransferItem>()
             .HasRequired(x => x.Transfer)
             .WithMany(x => x.Items)
             .HasForeignKey(x => x.TransferId)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transfer>()
            .HasRequired(x => x.ToStore)
            .WithMany()
            .HasForeignKey(x => x.ToStoreId)
            .WillCascadeOnDelete(false);

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set;}
        public DbSet<Product> Products { get; set; }
        public DbSet<Transfer> transfers { get; set; }
        public DbSet<TransferItem> transferItems { get; set; }
        public DbSet<ImportPermit> ImportPermit { get; set; }
        public DbSet<ImportPermitItem> ImportPermitItem { get; set;}
        public DbSet<ExchangePermit> ExchangePermit { get; set; }
        public DbSet<ExchangePermitItem> ExchangePermitItem { get; set;}
        
      
    }
}
