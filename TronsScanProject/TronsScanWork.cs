using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace TronsScanProject
{
    public  class TronsScanWork:DefoltTronsScanWork<ResponceLevelRisks,SettingsTronsScanDefault>
    {
        
        public TronsScanWork(SettingsTronsScanDefault settings)
        {
            Category = "transaction-info?";
            Settings = settings;
        }

       

        public async override Task<ResponceLevelRisks> GetResponse()
        {
            HttpClient httpClient = new HttpClient();

            var response = httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, BaseUrl + Category  + Settings.ToString())).Result;

            return JsonSerializer.Deserialize<ResponceLevelRisks>(await response.Content.ReadAsStringAsync()); ;
        }
    }
}
