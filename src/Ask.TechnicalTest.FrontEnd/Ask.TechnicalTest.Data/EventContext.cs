using System.Data.Entity;
using System.Reflection;

namespace Ask.TechnicalTest.Data
{
    public class EventContext : DbContext
    {
        public EventContext()
            : base("Name=EventContextConnection")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
