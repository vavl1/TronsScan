using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronsScanProject
{
    public  class SettingsTronsScanDefault
    {
        public string Hash { get; set; }
        public override string ToString()
        {
            return "hash="+Hash;
        }
    }
}
