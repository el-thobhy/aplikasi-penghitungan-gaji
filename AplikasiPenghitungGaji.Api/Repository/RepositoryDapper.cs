using Dapper;
using Framework.Auth;
using Microsoft.Data.SqlClient;
using System.Data;
using ViewModel;

namespace AplikasiPenghitungGaji.Api.Repository
{
    public class RepositoryDapper
    {
        private readonly string _connectionString;
        public RepositoryDapper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public PegawaiViewModel CreateDataPegawai(PegawaiViewModel model)
        {
            using (IDbConnection dbConnection = new SqlConnection(_connectionString))
            {
                dbConnection.Open();
                using(var transaction = dbConnection.BeginTransaction())
                {
                    try
                    {
                        var status = dbConnection.QueryFirstOrDefault<StatusViewModel>(
                            "SELECT Id, JenisStatus, Deskripsi, NilaiTunjangan FROM Table_Status WHERE Id = @StatusId"
                            , new {StatusId = model.StatusId}, transaction);

                        if (status == null) throw new Exception("Status Not Found");

                        var query = @"INSERT INTO Table_Pegawai(" +
                            "NomerPegawai, NamaPegawai, TanggalMasuk, JenisKelamin, StatusId, NilaiTunjangan, GajiPokok, UangMakan, IsDeleted, CreateBy, CreateDate, UangTransport) " +
                            "VALUES (" +
                            "@NomerPegawai, @NamaPegawai, @TanggalMasuk, @JenisKelamin, @StatusId, @NilaiTunjangan, @GajiPokok, @UangMakan, @IsDeleted, @CreateBy, @CreateDate, @UangTransport);" +
                            "SELECT CAST(SCOPE_IDENTITY() as int);";
                        var parameters = new
                        {
                            model.NomerPegawai, model.NamaPegawai, model.TanggalMasuk, model.JenisKelamin,
                            model.StatusId, status.NilaiTunjangan, model.GajiPokok, model.UangMakan, model.UangTransport,
                            IsDeleted = false,
                            CreateBy = ClaimContext.UserName(),
                            CreateDate = DateTime.Now
                        };
                        var rowAffected = dbConnection.Execute(query, parameters, transaction);
                        Console.WriteLine("Row Affected: "+rowAffected);
                        transaction.Commit();
                    }

                    catch (Exception e)
                    {
                        transaction.Rollback();
                        throw new Exception(e.Message);
                    }
                }
            }
            return model;
        }
        public List<ReturnPegawaiViewModel> GetPegawaiNative()
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT tp.* , ts.JenisStatus, ts.* FROM Table_Pegawai AS tp " +
                    "JOIN Table_Status AS ts ON tp.StatusId=ts.Id";
                List<ReturnPegawaiViewModel> result = connection.Query<ReturnPegawaiViewModel, StatusViewModel, ReturnPegawaiViewModel>(
                    sql,
                    (pegawai,status) =>
                    {
                        pegawai.Status = status;
                        return pegawai;
                    }
                    ).ToList();
                return result;
            }
        }

    }
}
