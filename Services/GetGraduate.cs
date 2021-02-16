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
    public class GetGraduate : IGetGraduate
    {
        public async Task<List<GradModel>> GetGradDegrees()
        {
            using (var client2 = new HttpClient())
            {
                client2.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client2.DefaultRequestHeaders.Accept.Clear();
                client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                try
                {
                    HttpResponseMessage response = await client2.GetAsync("api/degrees/graduate", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<GradModel>>>(data);
                    List<GradModel> gradList = new List<GradModel>();
                    GradModel gradMajors = new GradModel();

                    foreach (KeyValuePair<string, List<GradModel>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            gradList.Add(item);
                        }
                    }

                    return gradList;



                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<GradModel> gradMajorsList = new List<GradModel>();
                    return gradMajorsList;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<GradModel> gradMajorsList = new List<GradModel>();
                    return gradMajorsList;
                }
            }
        }
    }
}
