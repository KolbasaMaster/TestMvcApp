using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using TestApplication.Models;

namespace TestApplication
{
    public class TestAppContext :DbContext
    {
        public TestAppContext() :base ("companies")
        {
            Configuration.UseDatabaseNullSemantics = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(TestAppContext)));
        }

        internal virtual DbSet<CompanyDto> Company => Set<CompanyDto>();
        internal virtual DbSet<DeliveryDto> Delivery => Set<DeliveryDto>();

    }
}