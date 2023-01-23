using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.BL.Security
{
    [JsonObject("VariableConfig")]
    internal class VariableConfig
    {
        [JsonProperty("TokenSecret")]
        public string TokenSecret { get; set; }
        [JsonProperty("TokenExpire")]

        public double TokenExpire { get; set; }
    }
}
