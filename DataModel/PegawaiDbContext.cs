using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class PegawaiDbContext: DbContext
    {
        public PegawaiDbContext(DbContextOptions<PegawaiDbContext> options) : base(options)
        {
        }
        public DbSet<TableStatus> TableStatuses { get; set; }
        public DbSet<TablePegawai> TablePegawais { get; set; }
        public DbSet<TableLembur> TableLemburs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TableStatusConfiguration());
            modelBuilder.ApplyConfiguration(new TablePegawaiConfiguration());
            modelBuilder.ApplyConfiguration(new TableLemburConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
