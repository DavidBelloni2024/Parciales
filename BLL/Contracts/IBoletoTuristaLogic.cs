using DOMAIN;
using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IBoletoTuristaLogic : IBoletoService<Boleto>
    {
        IEnumerable<Boleto> GetFiltered(ColumnasBoleto campo, object valor); Boleto GetFilteredFirst(ColumnasBoleto campo, object valor);
        Boleto GetFilteredLast(ColumnasBoleto campo, object valor);
    }
}
