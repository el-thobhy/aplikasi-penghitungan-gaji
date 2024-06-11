﻿using AplikasiPenghitungGaji.Api.Repository;
using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace AplikasiPenghitungGaji.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PegawaiController : ControllerBase
    {
        private PegawaiReposiotry _repo;
        public PegawaiController(PegawaiDbContext dbContext)
        {
            _repo = new PegawaiReposiotry(dbContext);
        }

        [HttpPost]
        public async Task<PegawaiViewModel> CreateDataPegawai(PegawaiViewModel data)
        {
            return _repo.CreateDataPegawai(data);
        }
        [HttpGet]
        public async Task<List<ReturnPegawaiViewModel>> GetAllPegawai()
        {
           return _repo.GetAllPegawai();
        }
        [HttpPost("Lembur")]
        public async Task<LemburViewModel> CreateDataLembur(LemburViewModel data)
        {
            return _repo.CreateDataLembur(data);
        }
    }
}
