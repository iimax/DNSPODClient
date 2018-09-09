using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSPODClient.Models
{
    public class User
    {
        public string real_name { get; set; }

        public string user_type { get; set; }

        public string telephone { get; set; }

        public string im { get; set; }

        public string nick { get; set; }

        public string id { get; set; }

        public string email { get; set; }

        public string status { get; set; }

        public string email_verified { get; set; }

        public string weixin_binded { get; set; }

        public bool agent_pending { get; set; }

        public decimal balance { get; set; }

        public decimal smsbalance { get; set; }

        public string user_grade { get; set; }
    }

    public class UserResponse
    {
        public User user { get; set; }
    }
}
