using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Proje_Enes.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardWriterController : Controller
    { 
        private readonly UserManager<WriterUser> _userManager;

        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Values = values.Name + " " + values.Surname;

            //Weather Api
            string api = "64d476e683236d625b8f0a39392c240a";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;


            //statistics
            Context context = new Context();
            ViewBag.v1 = context.WriterMessages.Where(x=>x.Receiver== values.Email).Count();
            ViewBag.v2 = context.Announcements.Count();
            ViewBag.v3 = context.Users.Count();
            ViewBag.v4 = context.Skills.Count();
            return View();
        }
    }
}
