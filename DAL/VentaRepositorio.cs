using DOMAIN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VentaRepositorio
    {
        private List<Boleto> boletosVendidos = new List<Boleto>();


        public void Insertar(Boleto boleto)
        {
            boletosVendidos.Add(boleto);
        }

        public void Actualizar(Boleto boleto)
        {
            var existeBoleto = boletosVendidos.FirstOrDefault(b => b.Numero == boleto.Numero);
            if (existeBoleto != null)
            {
                existeBoleto.FechaSalida = boleto.FechaSalida;
                existeBoleto.TiempoEnDias = boleto.TiempoEnDias;   
            }
        }

        public Boleto Obtener(int numero)
        {
            return boletosVendidos.FirstOrDefault(b => b.Numero == numero);
        }

        public void Eliminar(int numero)
        {
            var boleto = boletosVendidos.FirstOrDefault(b => b.Numero == numero);
            if (boleto != null)
            {
                boletosVendidos.Remove(boleto);
            }
        }

        public List<Boleto> ObtenerTodo()
        {
            return boletosVendidos.ToList();
        }
    }
}
