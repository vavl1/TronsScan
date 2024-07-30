using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronsScanProject
{
    public abstract class DefoltTronsScanWork<T,S> where T:class
    {
        protected const  string BaseUrl = "https://apilist.tronscanapi.com/api/";
        protected string Category { get; set; }
        protected S Settings { get; set; }  
        public abstract  Task<T> GetResponse();
        
    }
}
