using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=NewDBEntities")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LandData> LandData { get; set; }
        public DbSet<Prediction> Predictions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



    }
}