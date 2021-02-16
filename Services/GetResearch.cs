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
    public class GetResearch : IGetResearch
    {
        public async Task<List<ResearchModel>> GetAllResearch()
        {
            using (var client7 = new HttpClient())
            {
                client7.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client7.DefaultRequestHeaders.Accept.Clear();
                client7.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client7.GetAsync("api/research/byFaculty", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<ResearchModel>>>(data);

                    List<ResearchModel> researchList = new List<ResearchModel>();
                    ResearchModel faculty = new ResearchModel();

                    foreach (KeyValuePair<string, List<ResearchModel>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            researchList.Add(item);
                        }
                    }

                    return researchList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<ResearchModel> researchList = new List<ResearchModel>();
                    return researchList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<ResearchModel> researchList = new List<ResearchModel>();
                    return researchList;
                    //return "Exception"; ;
                }
            }
        }
    }
}
