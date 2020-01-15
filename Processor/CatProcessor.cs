using CatCall.DataProvider;
using CatCall.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CatCall.Processor
{
    public class CatProcessor
    {
        public static async Task<FactModel> LoadFact()
        {
            string url = "https://cat-fact.herokuapp.com/facts/random?animal_type=cat&amount=1";
            FactModel fact = null;
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    // FactModel facts = await response.Content.ReadAsAsync<FactModel>();
                    var result = await response.Content.ReadAsStringAsync(); 
                    fact = JsonConvert.DeserializeObject<FactModel>(result);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            return fact;
        }
    }
}
