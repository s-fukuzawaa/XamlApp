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
    class APODRetriever
    {
        
        public async Task<APODRootObject> GetAPOD()
        {
            HttpClient httpClient = new HttpClient();


            string api = $"https://api.nasa.gov/planetary/apod?api_key=b6OIAb4HbQ1MaLlblj2OSNBOeUCGcmtw2FsKemJW";
            string response = await httpClient.GetStringAsync(api);

            APODRootObject apod = JsonConvert.DeserializeObject<APODRootObject>(response);


            return apod;
        }



    }
}
