using Ask.TechnicalTest.Business.Models;
using Ask.TechnicalTest.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Ask.TechnicalTest.Business.Services
{
    public class EventService : IEventService
    {
        private readonly EventContext _context;

        public EventService(EventContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            return await _context.Set<Data.Entities.Event>()
                .Select(x => new Event
                {
                    Name = x.Name,
                    Start = x.Start,
                    End = x.End,
                    Country = new Country
                    {
                        Name = x.Country.Name
                    }
                })
                .ToListAsync();
        }
    }
}