using AplikasiPenghitungGaji.Web.Services;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace AplikasiPenghitungGaji.Web.Controllers
{
    public class PegawaiController : Controller
    {
        private PegawaiServices _pegawaiServices;
        public PegawaiController(IConfiguration config)
        {
            _pegawaiServices = new PegawaiServices(config["ApiUrl"]);
        }
        public async Task<IActionResult> Index()
        {
            List<ReturnPegawaiViewModel> data = await _pegawaiServices.GetAllPegawai();
            return View(data);
        }
        public IActionResult Create()
        {
            ViewBag.Title = "Add New Pegawai";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(PegawaiViewModel data)
        {
            PegawaiViewModel response = await _pegawaiServices.CreateDataPegawai(data);
            if(response.StatusId>0)
            {
                return Json(new { dataResponse = response });
            }
            return View(data);
        }


    }
}
