using System;
using System.Data.Entity.Migrations;
using Ask.TechnicalTest.Data.Entities;

namespace Ask.TechnicalTest.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EventContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EventContext context)
        {
            var countries = context.Set<Country>();
            var uk = countries.Add(new Country
            {
                Name = "United Kingdom"
            });
            var spain = countries.Add(new Country
            {
                Name = "Spain"
            });
            countries.Add(new Country
            {
                Name = "France"
            });

            var events = context.Set<Event>();
            events.Add(new Event
            {
                Name = "first event",
                Country = uk,
                Start = new DateTime(DateTime.UtcNow.Year + 1, 1, 1),
                End = new DateTime(DateTime.UtcNow.Year + 1, 1, 4)
            });
            events.Add(new Event
            {
                Name = "second event",
                Country = uk,
                Start = new DateTime(DateTime.UtcNow.Year + 1, 2, 1),
                End = new DateTime(DateTime.UtcNow.Year + 1, 2, 6)
            });
            events.Add(new Event
            {
                Name = "third event",
                Country = spain,
                Start = new DateTime(DateTime.UtcNow.Year + 1, 3, 3),
                End = new DateTime(DateTime.UtcNow.Year + 1, 2, 6)
            });
        }
    }
}
