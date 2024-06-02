using BLL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Contracts;
using DAL.Factories;
using DOMAIN;

namespace BLL.Services
{
    public class BoletoService
        #region Singleton        
        private readonly static BoletoService _instance = new BoletoService();          
        public static BoletoService Current {get{return _instance;}}          
        private BoletoService()         

        {
        }

        #endregion

        IBoletoRepository Repository = Factory.Current.GetBoletoRepository();

        public void Add(Boleto obj)
        {
            Repository.Insert(obj);
        }



    }
}
