using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Probafeladat.Data.Seed;
using Probafeladat.Models;

namespace Probafeladat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Package> Packages { get; set; }
        public DbSet<ShippingState> ShippingStates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ShippingStates states = new ShippingStates();
            states.Create(builder);

            AddPackages addPackages = new AddPackages(this);
            addPackages.Create(builder);           

            base.OnModelCreating(builder);
        }
    }
}
