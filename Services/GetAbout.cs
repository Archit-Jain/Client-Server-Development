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
    public class GetAbout : IGetAbout
    {
        public async Task<List<AboutModel>> GetAllAbout()
        {
            using (var client4 = new HttpClient())
            {
                client4.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client4.DefaultRequestHeaders.Accept.Clear();
                client4.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client4.GetAsync("api/about", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<AboutModel>(data);

                    List<AboutModel> aboutList = new List<AboutModel>();
                    AboutModel about = new AboutModel();
                    //about.title = rtnResults.tittl
                    aboutList.Add(rtnResults);
                    /*foreach (KeyValuePair<string, List<AboutModel>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            aboutList.Add(item);
                        }
                    }
*/
                    return aboutList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<AboutModel> aboutList = new List<AboutModel>();
                    return aboutList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<AboutModel> aboutList = new List<AboutModel>();
                    return aboutList;
                    //return "Exception"; ;
                }
            }
        }
    }
}
