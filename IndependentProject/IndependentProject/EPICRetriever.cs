using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IndependentProject.Models;
using Newtonsoft.Json;

namespace IndependentProject
{
    class EPICRetriever
    {
        public async Task<IEnumerable<EPICRootObject>> GetEPIC()
        {
            HttpClient httpClient = new HttpClient();
            string apiUrl = $"https://api.nasa.gov/EPIC/api/natural/images?api_key=b6OIAb4HbQ1MaLlblj2OSNBOeUCGcmtw2FsKemJW";

            string response = await httpClient.GetStringAsync(apiUrl);

            IEnumerable<EPICRootObject> epic = JsonConvert.DeserializeObject<IEnumerable<EPICRootObject>>(response);

            return epic;
        }
    }
}
