using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;
using ViewModel;

namespace AplikasiPenghitungGaji.Web.Services
{
    public class PegawaiServices
    {
        private static readonly HttpClient client = new HttpClient();
        private IConfiguration configuration;
        private string routeApi = "";
        PegawaiViewModel response = new PegawaiViewModel();
        public PegawaiServices(string apiUrl)
        {
            routeApi = apiUrl;
        }

        public async Task<List<ReturnPegawaiViewModel>> GetAllPegawai()
        {
            string response = await client.GetStringAsync($"{routeApi}/Pegawai");
            List<ReturnPegawaiViewModel>? data = JsonConvert.DeserializeObject<List<ReturnPegawaiViewModel>>(response);
            return data ?? new List<ReturnPegawaiViewModel>();
        }

        public async Task<PegawaiViewModel> CreateDataPegawai(PegawaiViewModel input, string token)
        {
            string json = JsonConvert.SerializeObject(input);
            StringContent content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

            // Token
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


            var request = await client.PostAsync($"{routeApi}/Pegawai", content);
            if (request.IsSuccessStatusCode)
            {
                var apiResponse = await request.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<PegawaiViewModel>(apiResponse);
            }
            else
            {
                throw new Exception(request.StatusCode.ToString());
            }
            return response;
        }       
    }
}
