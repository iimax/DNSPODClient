using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSPODClient.Models
{
    public class ResponseBase<T>  where T : class
    {
        public ResponseStatus status { get; set; }

        public T info { get; set; }
    }

    public class ResponseStatus
    {
        public int code { get; set; }

        public string message { get; set; }

        public DateTime created_at { get; set; }
    }
}
