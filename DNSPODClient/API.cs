using DNSPODClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DNSPODClient
{
    
    public class API
    {
        private HttpClient client = new HttpClient();

        public API()
        {
            client.BaseAddress = new Uri("https://dnsapi.cn");
        }

        public string BuildPostData()
        {
            return string.Empty;
        }

        public async Task<UserResponse> GetUserDetail()
        {
            var requestBase = new RequestBase();
            var content = new StringContent(requestBase.ToString());
            var x = await client.PostAsync("/User.Detail", content);
            if (x.IsSuccessStatusCode)
            {
                var rs = await x.Content.ReadAsStringAsync();
            }

            return null;
        }
    }
}
