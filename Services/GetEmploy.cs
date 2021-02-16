using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3_FinalExam.Services
{
    public class GetEmploy : IGetEmploy
    {
        public async Task<List<EmployModel>> GetAllEmploy()
        {
            using (var client5 = new HttpClient())
            {
                client5.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client5.DefaultRequestHeaders.Accept.Clear();
                client5.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client5.GetAsync("api/employment/coopTable/coopInformation", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<EmployModel>>>(data);

                    List<EmployModel> employList = new List<EmployModel>();
                    EmployModel employ = new EmployModel();

                    foreach (KeyValuePair<string, List<EmployModel>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            employList.Add(item);
                        }
                    }

                    return employList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<EmployModel> employList = new List<EmployModel>();
                    return employList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<EmployModel> employList = new List<EmployModel>();
                    return employList;
                    //return "Exception"; ;
                }
            }
        }
    }
}
