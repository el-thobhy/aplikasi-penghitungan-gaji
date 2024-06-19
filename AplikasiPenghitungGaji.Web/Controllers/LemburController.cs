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
            List<GetAllLemburViewModel> data = await _services.GetAllLembur();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Input Data Lembur";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(LemburViewModel model)
        {

            string token = HttpContext.Session.GetString("Token");
            LemburViewModel data = await _services.CreateLembur(model, token);
            if(data.Id < 0)
            {
                ViewBag.Message = "Fail To Post Data";
            }
            return RedirectToAction("Index", "Pegawai");
        }
    }
}
