using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Ejecutivo : Boleto
    {
        public Ejecutivo(int numero, DateTime fechaSalida, int tiempoEnDias, float costoEmbarque) : base(numero, fechaSalida, tiempoEnDias, costoEmbarque) 
        { 
        }

        /*public override double CostoBoleto()
        {
            // Costo base más incremento para boleto ejecutivo
            return 9950 + 9800 + CostoEmbarque;
        }*/
    }
}
