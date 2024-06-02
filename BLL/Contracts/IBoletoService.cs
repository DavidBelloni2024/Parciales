using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;
using Enums;

namespace BLL.Contracts
{
    public interface IBoletoService <T> : IGenericBussinesLogic <T>
    {
        //IEnumerable<Boleto> GetFiltered(ColumnasBoleto campo, object valor); Boleto GetFilteredFirst(ColumnasBoleto campo, object valor);
        //Boleto GetFilteredLast(ColumnasBoleto campo, object valor);

        int Agregar(T boleto);

    }
}
