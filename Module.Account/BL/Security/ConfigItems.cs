using Newtonsoft.Json;

namespace Module.Account.BL.Security
{
    [JsonObject("VariableConfig")]
    internal class VariableConfig
    {
        [JsonProperty("TokenSecret")]
        public string TokenSecret { get; set; }

        [JsonProperty("TokenExpire")]
        public double TokenExpire { get; set; }

        [JsonProperty("ProfileId")]
        public string ProfileId { get; set; }

        [JsonProperty("SenderId")]
        public string SenderId { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }
    }
}