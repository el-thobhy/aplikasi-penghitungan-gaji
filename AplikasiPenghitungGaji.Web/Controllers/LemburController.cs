using AplikasiPenghitungGaji.Web.Services;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace AplikasiPenghitungGaji.Web.Controllers
{
    public class LemburController : Controller
    {
        private LemburServices _services;
        public LemburController(IConfiguration config)
        {
            _services = new LemburServices(config["ApiUrl"]);
        }

        public async Task<IActionResult> Index()
        {
            List<LemburViewModel> data = await _services.GetAllLembur();
            return View(data);
        }
    }
}
