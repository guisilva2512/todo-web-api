using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Entities;

namespace Todo.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> Todos { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TodoItem>().Property(x => x.Id);
        //    modelBuilder.Entity<TodoItem>().Property(x => x.User).HasMaxLength(120).HasColumnType("varchar(120)");
        //    modelBuilder.Entity<TodoItem>().Property(x => x.Title).HasMaxLength(160).HasColumnType("varchar(120)");
        //    modelBuilder.Entity<TodoItem>().Property(x => x.Done).HasColumnType("bit");
        //    modelBuilder.Entity<TodoItem>().Property(x => x.Date);
        //    modelBuilder.Entity<TodoItem>().HasIndex(b => b.User);
        //}

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            // Install-Package Microsoft.EntityFramework
            // Install-Package Microsoft.EntityFramework.Design
            // Install-Package Microsoft.EntityFramework.Relational

            modelbuilder.Entity<TodoItem>().ToTable("Todo");
            modelbuilder.Entity<TodoItem>().Property(x => x.Id);
            modelbuilder.Entity<TodoItem>().Property(x => x.User).HasMaxLength(120).HasColumnType("varchar(120)");
            modelbuilder.Entity<TodoItem>().Property(x => x.Title).HasMaxLength(160).HasColumnType("varchar(160)");
            modelbuilder.Entity<TodoItem>().Property(x => x.Done).HasColumnType("bit");
            modelbuilder.Entity<TodoItem>().Property(x => x.Date);
            modelbuilder.Entity<TodoItem>().Property(b => b.User);
        }

    }
}
