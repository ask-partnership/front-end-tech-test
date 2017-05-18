using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ask.TechnicalTest.Data.Entities;

namespace Ask.TechnicalTest.Business.Services
{
    public class EventService : IEventService
    {
        public Task<IEnumerable<Event>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}