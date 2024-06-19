using AplikasiPenghitungGaji.Api.Repository;
using DataModel;
using Framework.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using ViewModel;

namespace AplikasiPenghitungGaji.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PegawaiController : ControllerBase
    {
        private PegawaiReposiotry _repo;
        private RepositoryDapper _repoDapper;
        public PegawaiController(PegawaiDbContext dbContext, IConfiguration config)
        {
            _repo = new PegawaiReposiotry(dbContext);
            _repoDapper = new RepositoryDapper(config["ConnectionStrings:DB_Conn"]);
        }

        [HttpPost]
        [ReadableBodyStream(Roles = "ADMINISTRATOR")]
        public async Task<PegawaiViewModel> CreateDataPegawai(PegawaiViewModel data)
        {
            return _repo.CreateDataPegawai(data);
        }

        //Native Query
        [HttpPost("CreatePegawaiNative")]
        [ReadableBodyStream(Roles = "ADMINISTRATOR")]
        public async Task<PegawaiViewModel> CreatePegawaiNative(PegawaiViewModel data)
        {
            return _repoDapper.CreateDataPegawai(data);
        }
        [HttpGet("GetPegawaiNative")]
        public async Task<List<ReturnPegawaiViewModel>> GetPegawaiNative()
        {
            return _repoDapper.GetPegawaiNative();
        }

        [HttpGet]
        public async Task<List<ReturnPegawaiViewModel>> GetAllPegawai()
        {
            return _repo.GetAllPegawai();
        }
        [HttpPost("Lembur")]
        [ReadableBodyStream(Roles = "ADMINISTRATOR")]
        public async Task<LemburViewModel> CreateDataLembur(LemburViewModel data)
        {
            return _repo.CreateDataLembur(data);
        }
        [HttpGet("GetLembur")]
        public async Task<List<GetAllLemburViewModel>> GetDataLembuer()
        {
            return _repo.GetLembur();
        }
    }
}
