using DAL;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Venta
    {
        private VentaRepositorio ventaRepositorio;

        public Venta()
        {
            ventaRepositorio = new VentaRepositorio();
        }

        public void AgregarBoleto(Boleto boleto)
        {
            ventaRepositorio.Insertar(boleto);
        }

        public void ActualizarBoleto(Boleto boleto)
        {
            ventaRepositorio.Actualizar(boleto);
        }

        public Boleto BuscarBoleto(int numero)
        {
            return ventaRepositorio.Obtener(numero);
        }

        public void EliminarBoleto(int numero)
        {
            ventaRepositorio.Eliminar(numero);
        }

        public List<Boleto> ListarTodos()
        {
            return ventaRepositorio.ObtenerTodo();
        }
    }
}
