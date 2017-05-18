using System.Collections.Generic;
using System.Threading.Tasks;
using Ask.TechnicalTest.Data.Entities;

namespace Ask.TechnicalTest.Business.Services
{
    public interface IEventService
    {
        Task<IEnumerable<Event>> GetAll();
    }
}
