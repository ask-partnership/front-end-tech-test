using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Ask.TechnicalTest.FrontEnd.ViewModels;
using Ask.TechnicalTest.Business.Services;

namespace Ask.TechnicalTest.FrontEnd.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<ActionResult> Index()
        {
            var viewModel = new EventCollectionViewModel();

            return View(viewModel);
        }
    }
}