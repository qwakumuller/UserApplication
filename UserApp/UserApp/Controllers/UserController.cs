using System.Web.Mvc;

namespace UserApp.Controllers
{
    public class UserController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}