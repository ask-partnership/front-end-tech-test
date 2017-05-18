using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Ask.TechnicalTest.Data.Entities;

namespace Ask.TechnicalTest.Data.Mappings
{
    public class EventMapper : EntityTypeConfiguration<Event>
    {
        public EventMapper()
        {
            HasKey(e => e.Id);
            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
