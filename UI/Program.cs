using BLL;
using BLL.Services;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Establecer el costo de embarque inicial
            //Boleto.CostoEmbarque = 100;

            Boleto boleto1 = new Turista(1, DateTime.Now, 7, 100);
            BoletoService.Current.Add(boleto1);

            /*
            Venta venta = new Venta();

            //Despliegue de Informacion Comercial
            Console.WriteLine($" INFORMACIÓN COMERCIAL ");
            Console.WriteLine($"¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯ \n");
            Console.WriteLine($"▬ TARIFA BOLETO TURISTA: $18350" );
            Console.WriteLine($"▬ TARIFA BOLETO EJECUTIVO: $19750");
            Console.WriteLine($"▬ COSTO DE EMBARQUE: $100 \n");

            // Crear boletos
            Boleto boletoTurista1 = new Turista(1, DateTime.Now, 7);
            Boleto boletoTurista2 = new Turista(2, DateTime.Now, 5);
            Boleto boletoEjecutivo1 = new Ejecutivo(3, DateTime.Now, 7);
            Boleto boletoEjecutivo2 = new Ejecutivo(4, DateTime.Now, 8);
            Boleto boletoEjecutivo3 = new Ejecutivo(5, DateTime.Now, 10);

            // Agregar boletos a la venta
            venta.AgregarBoleto(boletoTurista1);
            venta.AgregarBoleto(boletoTurista2);
            venta.AgregarBoleto(boletoEjecutivo1);
            venta.AgregarBoleto(boletoEjecutivo2);
            venta.AgregarBoleto(boletoEjecutivo3);


            // Listar todos los boletos vendidos
            Console.WriteLine($" VOLETOS VENDIDOS ");
            Console.WriteLine($"¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯ \n");

            foreach (var boleto in venta.ListarTodos())
            {
                Console.WriteLine($" ♦ Boleto Numero: {boleto.Numero}, Tipo: {boleto.GetType().Name}, Costo: {boleto.CostoBoleto()}, Fecha Regreso: {boleto.CalcularRegreso()}");
            }
            */
            Console.ReadKey();
        }
    }
}
