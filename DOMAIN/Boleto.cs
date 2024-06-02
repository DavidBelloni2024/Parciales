using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public abstract class Boleto
    {
        
        //public int Id { get; set; } 
        public int Numero {  get; set; }    
        public DateTime FechaSalida { get; set; }
        public int TiempoEnDias { get; set; }
        public  float CostoEmbarque {  get; set; }


        public Boleto(int numero, DateTime fechaSalida, int tiempoEnDias, float costoEmbarque )
        {
            Numero = numero;
            FechaSalida = fechaSalida;
            TiempoEnDias = tiempoEnDias;
            CostoEmbarque = costoEmbarque;
            
        }
        public DateTime CalcularRegreso()
        {
            return FechaSalida.AddDays(TiempoEnDias);
        }
        //public abstract float CostoBoleto();

        public enum TipoBoleto
        {
            Turista,
            Ejecutivo
        }




    }
}
