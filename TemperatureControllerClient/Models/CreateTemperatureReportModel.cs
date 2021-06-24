using Newtonsoft.Json;
using System;

namespace TemperatureControllerClient.Models
{
    public class CreateTemperatureReportModel
    {
        [JsonProperty("controllerId")]
        public Guid ControllerId { get; set; }
        
        [JsonProperty("celsius")]
        public double Celsius { get; set; }
    }
}
