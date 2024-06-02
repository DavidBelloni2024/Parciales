using DAL.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SL.DAL.Tools;



namespace DAL.Repositories
{
    internal class BoletoRepository : IBoletoRepository
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Venta_Boleto] (Numero, FechaSalida, TiempoEnDias, CostoEmbarque) VALUES (@Numero, @FechaSalida, @TiempoEnDias, @CostoEmbarque)";
        }
        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Venta_Boleto] SET Id = @Id, Numero = @Numero, FechaSalida = @FechaSalida, TiempoEnDias = @TiempoEnDias, CostoEmbarque = @CostoEmbarque WHERE Id = @Id";
        }
        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Venta_Boleto] WHERE Id = @Id";
        }
        private string SelectOneGuidStatement
        {
            get => "SELECT * FROM [dbo].[Venta_Boleto] WHERE Id = @Id";
        }
        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Venta_Boleto]";
        }
        #endregion


        public void Delete(Boleto obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Boleto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Boleto GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Boleto obj)
        {
            try

            {
                SqlHelper.ExecuteNonQuery(

                    InsertStatement, CommandType.Text,
                    //new SqlParameter("@Id", obj.Id),
                    new SqlParameter("@Numero", obj.Numero),
                    new SqlParameter("@FechaSalida", obj.FechaSalida),
                    new SqlParameter("@TiempoEnDias", obj.TiempoEnDias),
                    new SqlParameter("@CostoEmbarque", obj.CostoEmbarque));
            }

            catch
            { 
                Console.WriteLine($"No se puede insertar objeto especifico");
            }
        }

        public void Update(Boleto obj)
        {
            throw new NotImplementedException();
        }
    }
}
