using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Enums
{
    public enum ColumnasBoleto
    {
        [Description("Numero")] Numero,
        [Description("FechaSalida")] FechaSalida,
        [Description("TiempoEnDias")] TiempoEnDias,
        [Description("CostoEmbarque")] CostoEmbarque, 
    }
}
