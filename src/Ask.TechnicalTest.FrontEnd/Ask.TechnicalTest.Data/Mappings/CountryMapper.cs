using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Ask.TechnicalTest.Data.Entities;

namespace Ask.TechnicalTest.Data.Mappings
{
    public class CountryMapper : EntityTypeConfiguration<Country>
    {
        public CountryMapper()
        {
            HasKey(e => e.Id);
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}