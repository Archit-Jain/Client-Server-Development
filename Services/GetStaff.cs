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
    public class GetStaff : IGetStaff
    {
        public async Task<List<StaffModel>> GetAllStaff()
        {
            using (var client3 = new HttpClient())
            {
                client3.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client3.DefaultRequestHeaders.Accept.Clear();
                client3.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client3.GetAsync("api/people/staff", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<StaffModel>>>(data);

                    List<StaffModel> staffList = new List<StaffModel>();
                    StaffModel staff = new StaffModel();

                    foreach (KeyValuePair<string, List<StaffModel>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            staffList.Add(item);
                        }
                    }

                    return staffList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<StaffModel> staffList = new List<StaffModel>();
                    return staffList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<StaffModel> staffList = new List<StaffModel>();
                    return staffList;
                    //return "Exception"; ;
                }
            }
        }
    }
}
