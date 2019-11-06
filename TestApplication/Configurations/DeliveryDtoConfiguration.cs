using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using TestApplication.Models;

namespace TestApplication.Configurations
{
    public class DeliveryDtoConfiguration : EntityTypeConfiguration<DeliveryDto>
    {
        public DeliveryDtoConfiguration()
        {
            ToTable("Delivery");
            HasKey(x => x.Number);
            Property(x => x.INN).HasColumnName("INN");
            Property(x => x.Number).HasColumnName("Number");
            Property(x => x.Sum).HasColumnName("Sum");
            Property(x => x.Сurrency).HasColumnName("Currency");

            HasRequired(x => x.CompanyDto).WithMany(x => x.Delivery).HasForeignKey(x => x.INN);
        }
    }
}