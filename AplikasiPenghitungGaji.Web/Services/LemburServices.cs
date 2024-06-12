using Newtonsoft.Json;
using ViewModel;

namespace AplikasiPenghitungGaji.Web.Services
{
    public class LemburServices
    {
        private static readonly HttpClient client = new HttpClient();
        private IConfiguration configuration;
        private string routeApi = "";
        LemburViewModel response = new LemburViewModel();

        public LemburServices(string apiUrl)
        {
            routeApi = apiUrl;
        }
        public async Task<List<LemburViewModel>> GetAllLembur()
        {
            string response = await client.GetStringAsync($"{routeApi}/Pegawai/GetLembur");
            List<LemburViewModel>? data = JsonConvert.DeserializeObject<List<LemburViewModel>>(response);
            return data ?? new List<LemburViewModel>();
        }
    }
}
