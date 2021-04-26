using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FileAPI_Client
{
    class Downloader
    {
        private List<string> GetFiles()
        { 
             var client = new HttpClient();
             var response =  client.GetAsync(String.Format(@"https://localhost:44342/api/dokumentumok/"));
             var data =  response.Content.ReadAsStringAsync();
             var list = JsonConvert.DeserializeObject<List<string>>(data);
            return list;
            
        }
    }
}
