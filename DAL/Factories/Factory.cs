using DAL.Contracts;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factories
{
    public class Factory
    {
        #region Singleton
        private readonly static Factory _instance = new Factory();

        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory()
        {
            //Implement here the initialization code
        }
        #endregion

        public IBoletoRepository GetBoletoRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];

            if (backend == "DAL.Repositories.SqlServer")
                return new BoletoRepository();
            else
                return null;
        }
    }
}
