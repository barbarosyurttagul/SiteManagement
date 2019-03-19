using Barbarosoft.SiteManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barbarosoft.SiteManagement.DataAccess.Concrete.EntityFramework
{
    public class SiteManagementContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1AC67OU\\SQLEXPRESS; Database=SiteManagementDb;Integrated Security=True");
        }

        public DbSet<Flat> Flats { get; set; }
        public DbSet<CurrentOccupier> CurrentOccupiers { get; set; }
    }
}
