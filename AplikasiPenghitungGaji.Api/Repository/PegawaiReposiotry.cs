using DataModel;
using Framework.Auth;
using Microsoft.EntityFrameworkCore;
using ViewModel;

namespace AplikasiPenghitungGaji.Api.Repository
{
    public class PegawaiReposiotry
    {
        private PegawaiDbContext _dbContext;
        public PegawaiReposiotry(PegawaiDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }
        public PegawaiViewModel CreateDataPegawai(PegawaiViewModel model)
        {
            try
            {
                StatusViewModel? status = new StatusViewModel();
                status = (from o in _dbContext.TableStatuses
                          where o.Id == model.StatusId
                          select new StatusViewModel
                          {
                              Id = o.Id,
                              JenisStatus = o.JenisStatus,
                              Deskripsi = o.Deskripsi,
                              NilaiTunjangan = o.NilaiTunjangan
                          }).FirstOrDefault();

                TablePegawai entity = new TablePegawai()
                {
                    NomerPegawai = model.NomerPegawai,
                    NamaPegawai = model.NamaPegawai,
                    TanggalMasuk = model.TanggalMasuk,
                    JenisKelamin = model.JenisKelamin,
                    StatusId = model.StatusId,
                    NilaiTunjangan = status.NilaiTunjangan,
                    GajiPokok = model.GajiPokok,
                    UangMakan = model.UangMakan,
                    UangTransport = model.UangTransport,
                    CreateBy = ClaimContext.UserName(),
                    CreateDate = DateTime.Now
                };
                _dbContext.TablePegawais.Add(entity);
                _dbContext.SaveChanges();
                model.Id = entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
            return model;
        }

        public List<ReturnPegawaiViewModel> GetAllPegawai()
        {
            List<ReturnPegawaiViewModel> result = new List<ReturnPegawaiViewModel>();
            try
            {
                result = (from o in _dbContext.TablePegawais
                          select new ReturnPegawaiViewModel
                          {
                              NomerPegawai = o.NomerPegawai,
                              NamaPegawai = o.NamaPegawai,
                              TanggalMasuk = o.TanggalMasuk,
                              JenisKelamin = o.JenisKelamin,
                              StatusId = o.StatusId,
                              NilaiTunjangan = o.NilaiTunjangan,
                              GajiPokok = o.GajiPokok,
                              Status = new StatusViewModel
                              {
                                  Id = o.Id,
                                  JenisStatus = o.Status.JenisStatus,
                                  Deskripsi = o.Status.Deskripsi,
                                  NilaiTunjangan = o.Status.NilaiTunjangan,
                                  CreateBy = o.Status.CreateBy,
                                  CreateDate = o.Status.CreateDate
                              },
                              UangMakan = o.UangMakan,
                              UangTransport = o.UangTransport,
                              CreateBy = o.CreateBy,
                              CreateDate = o.CreateDate,
                              IsDeleted = o.IsDeleted,
                              JenisStatus = o.Status.JenisStatus,
                              UangLembur = o.UangLembur,
                              Id = o.Id,
                          }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public LemburViewModel CreateDataLembur(LemburViewModel model)
        {
            try
            {
                TablePegawai pegawai = _dbContext.TablePegawais
                    .Where(o => o.Id == model.IdPegawai)
                    .FirstOrDefault();

                TableLembur entity = new TableLembur()
                {
                    IdPegawai = model.IdPegawai,
                    DokumenLembur = model.DokumenLembur,
                    Tanggal = model.Tanggal,
                    JumlahLembur = model.JumlahLembur,
                    CreateBy = ClaimContext.UserName() ,
                    CreateDate = DateTime.Now,
                    NomerPegawai = pegawai.NomerPegawai
                };

                _dbContext.TableLemburs.Add(entity);
                _dbContext.SaveChanges();
                model.Id = entity.Id;

                //update uang lembur pada table pegawai
                double uangLembur = 0;
                
                for(int i = 0; i< entity.JumlahLembur;  i++)
                {
                    if (i == 0)
                    {
                        uangLembur += (pegawai.GajiPokok + pegawai.UangMakan + pegawai.UangTransport) / 173 * 1.5;
                    }
                    else
                    {
                        uangLembur += (pegawai.GajiPokok + pegawai.UangMakan + pegawai.UangTransport) / 173 * 2;
                    }
                }
                pegawai.UangLembur = pegawai.UangLembur != null ? pegawai.UangLembur+uangLembur : uangLembur;
                pegawai.ModifiedBy = "admin";
                pegawai.ModifiedDate = DateTime.Now;
                _dbContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
            return model;
        }

        public List<GetAllLemburViewModel> GetLembur()
        {
            List<GetAllLemburViewModel> result = new List<GetAllLemburViewModel>();
            result = (from o in _dbContext.TableLemburs
                      where o.IsDeleted == false
                      select new GetAllLemburViewModel
                      {
                          Id = o.Id,
                          DokumenLembur = o.DokumenLembur,
                          IdPegawai = o.IdPegawai,
                          JumlahLembur = o.JumlahLembur,
                          DataPegawai = new ReturnPegawaiViewModel
                          {
                              NomerPegawai = o.DataPegawai.NomerPegawai,
                              NamaPegawai = o.DataPegawai.NamaPegawai,
                              TanggalMasuk = o.DataPegawai.TanggalMasuk,
                              JenisKelamin = o.DataPegawai.JenisKelamin,
                              StatusId = o.DataPegawai.StatusId,
                              NilaiTunjangan = o.DataPegawai.NilaiTunjangan,
                              GajiPokok = o.DataPegawai.GajiPokok,
                              Status = new StatusViewModel
                              {
                                  Id = o.Id,
                                  JenisStatus = o.DataPegawai.Status.JenisStatus,
                                  Deskripsi = o.DataPegawai.Status.Deskripsi,
                                  NilaiTunjangan = o.DataPegawai.Status.NilaiTunjangan,
                                  CreateBy = o.DataPegawai.Status.CreateBy,
                                  CreateDate = o.DataPegawai.Status.CreateDate
                              },
                              UangMakan = o.DataPegawai.UangMakan,
                              UangTransport = o.DataPegawai.UangTransport,
                              CreateBy = o.DataPegawai.CreateBy,
                              CreateDate = o.DataPegawai.CreateDate,
                              IsDeleted = o.DataPegawai.IsDeleted,
                              JenisStatus = o.DataPegawai.Status.JenisStatus,
                              UangLembur = o.DataPegawai.UangLembur,
                              Id = o.Id,
                          },
                          Tanggal = o.Tanggal
                      }).ToList();

            return result;
        }
    }
}
