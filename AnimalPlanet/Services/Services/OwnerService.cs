using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces.Services;
using Services.Persistance;
using Services.Models;
using System.Net.Http;
using Services.Helpers;
using System.Threading;

namespace Services.Services
{
    public class OwnerService : IOwnerService
    {
        public IQueryable<Owner> GetAllOwnerList()
        {
            try
            {
                List<Owner> listOwner = new List<Owner>();
                listOwner = GetWebApiData<List<Owner>>("");
                return listOwner.AsQueryable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T GetWebApiData<T>(string strURL)
        {
            var data = default(T);

            var handler = new HttpClientHandler { PreAuthenticate = true, UseDefaultCredentials = true };

            using (var client = new HttpClient(handler) { BaseAddress = new Uri(ApiHelper.WebApiAddress) })
            {
                try
                {
                    var resp = client.GetAsync(strURL).Result;

                    if (!resp.IsSuccessStatusCode)
                        return default(T);

                    data = resp.Content.ReadAsAsync<T>().Result;

                }
                catch (Exception ex)
                {
                    throw ex;

                }

                return data;
            }

        }
    }


}
