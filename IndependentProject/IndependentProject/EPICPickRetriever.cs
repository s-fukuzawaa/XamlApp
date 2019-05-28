using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndependentProject.Models;

using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace IndependentProject
{
    public class EPICPickRetriever
    {
        private string[] date;
        public EPICPickRetriever(string[] date)
        {
            this.date = date;
        }
        public async Task<IEnumerable<EPICRootObject>> GetEPIC()
        {
            HttpClient httpClient = new HttpClient();
            string apiUrl = $"https://epic.gsfc.nasa.gov/api/natural/date/"+this.date[0]+"-"+this.date[1]+"-"+this.date[2];

            string response = await httpClient.GetStringAsync(apiUrl);

            IEnumerable<EPICRootObject> epic = JsonConvert.DeserializeObject<IEnumerable<EPICRootObject>>(response);

            return epic;
        }
    }
}
