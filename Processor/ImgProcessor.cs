using CatApp.DataProvider;
using CatApp.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CatApp.Processor
{
    class ImgProcessor
    {
        public static async Task<ImgModel> LoadImg()
        {
            string url = "http://aws.random.cat/meow";
            ImgModel fact = null;
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    fact = JsonConvert.DeserializeObject<ImgModel>(result);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                return fact;
            }
        }
    }
}
