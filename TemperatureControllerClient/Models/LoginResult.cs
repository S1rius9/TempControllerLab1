using Newtonsoft.Json;

namespace TemperatureControllerClient.Models
{
    public class LoginResult
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }
}
