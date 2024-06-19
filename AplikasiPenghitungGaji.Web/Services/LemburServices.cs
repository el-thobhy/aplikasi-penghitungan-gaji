using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
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
        public async Task<List<GetAllLemburViewModel>> GetAllLembur()
        {
            string response = await client.GetStringAsync($"{routeApi}/Pegawai/GetLembur");
            List<GetAllLemburViewModel>? data = JsonConvert.DeserializeObject<List<GetAllLemburViewModel>>(response);
            return data ?? new List<GetAllLemburViewModel>();
        }
        public async Task<LemburViewModel> CreateLembur(LemburViewModel model, string token)
        {
            string json = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var request = await client.PostAsync($"{routeApi}/Pegawai/Lembur", content);


            if (request.IsSuccessStatusCode)
            {
                var apiResponse = await request.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<LemburViewModel>(apiResponse);
            }
            return response ?? new LemburViewModel();
        }
    }
}
