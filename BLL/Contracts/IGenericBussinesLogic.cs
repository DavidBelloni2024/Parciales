using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IGenericBussinesLogic <T> 
    {
        void Add(T obj);

        void Remove(T obj);

        void Updater(T obj);

        T GetOne(T id);

        IEnumerable<T> GetAll();

    }
}
