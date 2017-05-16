using System.Web.Mvc;
using Ask.TechnicalTest.FrontEnd.ViewModels;

namespace Ask.TechnicalTest.FrontEnd.Controllers
{
    public class EventController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new EventCollectionViewModel();
            return View(viewModel);
        }
    }
}