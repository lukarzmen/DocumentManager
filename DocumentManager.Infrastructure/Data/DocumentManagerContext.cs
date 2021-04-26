using DocumentManager.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentManager.Infrastructure.Data
{
    public class DocumentManagerContext : DbContext
    {
        public DocumentManagerContext(DbContextOptions<DocumentManagerContext> options) : base(options)
        {
        }

        public DbSet<Document> Documents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("Documents");
        }
    }
}
