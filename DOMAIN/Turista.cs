using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Turista : Boleto
    {
        public Turista(int numero, DateTime fechaSalida, int tiempoEnDias, float costoEmbarque) : base(numero, fechaSalida, tiempoEnDias, costoEmbarque)
        {
        }

        /*public override double CostoBoleto()
        {
            // Costo base más incremento para boleto turista
            return 9950 + 8400 + CostoEmbarque;
        }*/
    }
}
