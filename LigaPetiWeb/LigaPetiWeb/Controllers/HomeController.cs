using System;
using System.Linq;
using System.Web.Mvc;
using LigaPetiDbModel.DataContext.LigaPeti;

namespace LigaPetiWeb.Controllers
{
    public class HomeController : Controller
    {
        readonly LigaPetiDb m_context;
        public HomeController()
        {
            m_context = new LigaPetiDb();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = m_context.Seasons.First().Year.ToString();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}