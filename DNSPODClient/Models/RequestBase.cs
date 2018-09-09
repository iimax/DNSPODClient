using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSPODClient.Models
{
    public class RequestBase
    {
        /// <summary>
        /// 用于鉴权的 API Token
        /// </summary>
        public string login_token { get; set; }

        public string format { get; set; } = "json";

        public string lang { get; set; } = "cn";

        public string error_on_empty { get; set; } = "no";
    }
}
