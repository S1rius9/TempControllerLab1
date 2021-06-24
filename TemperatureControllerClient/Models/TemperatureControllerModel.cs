using Newtonsoft.Json;
using System;

namespace TemperatureControllerClient.Models
{
    public class TemperatureControllerModel
    {
        [JsonProperty("id")]
        public Guid? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reportIntervalSeconds")]
        public double ReportIntervalSeconds { get; set; }

        [JsonProperty("celsiusToStartAeration")]
        public double CelsiusToStartAeration { get; set; }

        [JsonProperty("celsiusToFinishAeration")]
        public double CelsiusToFinishAeration { get; set; }

        [JsonProperty("celsiusToStartHeating")]
        public double CelsiusToStartHeating { get; set; }

        [JsonProperty("celsiusToFinishHeating")]
        public double CelsiusToFinishHeating { get; set; }

        [JsonProperty("bottomEdgeToAlert")]
        public double BottomEdgeToAlert { get; set; }

        [JsonProperty("upperEdgeToAlert")]
        public double UpperEdgeToAlert { get; set; }
    }
}