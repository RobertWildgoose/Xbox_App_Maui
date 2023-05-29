using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbox_App.Models;
using Xbox_App.Services.Interfaces;

namespace Xbox_App.Services.Implementations
{
    public class ApiRequestService : IApiRequestService
    {
        public async Task<T> GetData<T>(string url) where T : BaseModel
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseOutput = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<T>(responseOutput);
                    return responseObject;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public async Task<List<T>> GetListedData<T>(string url) where T : BaseModel
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseOutput = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<List<T>>(responseOutput);
                    return responseObject;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
