using System.Data.Entity.ModelConfiguration;
using TestApplication.Models;

namespace TestApplication.Configurations
{
    public class CompanyDtoConfiguration : EntityTypeConfiguration<CompanyDto>
    {
        public CompanyDtoConfiguration()
        {
            ToTable("Company");
            HasKey(x => x.INN);
            Property(x => x.INN).HasColumnName("INN");
            Property(x => x.Name).HasColumnName("CompanyName");

            HasMany(x => x.Delivery).WithRequired(x => x.CompanyDto).HasForeignKey(x => x.INN);
            
        }
    }
}