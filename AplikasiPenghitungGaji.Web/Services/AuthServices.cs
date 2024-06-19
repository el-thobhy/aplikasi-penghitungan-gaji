using Newtonsoft.Json;
using System.Text;
using ViewModel;

namespace AplikasiPenghitungGaji.Web.Services
{
    public class AuthServices
    {
        private static readonly HttpClient client = new HttpClient();
        private IConfiguration configuration;
        private string routeApi = "";
        
        public AuthServices(string apiUrl)
        {
            routeApi = apiUrl;
        }

        public async Task<ReturnLoginViewModel> Login(LoginViewModel model)
        {
            ReturnLoginViewModel result = new ReturnLoginViewModel();
            string json = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

            var requset = await client.PostAsync(routeApi + $"/User/Login", content);
            if(requset.IsSuccessStatusCode)
            {
                var api = await requset.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ReturnLoginViewModel>(api);
            }

            return result ?? new ReturnLoginViewModel();
        }

    }
}
