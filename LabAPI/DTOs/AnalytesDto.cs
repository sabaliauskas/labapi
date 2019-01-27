using Newtonsoft.Json;

namespace LabAPI.DTOs
{
  public class AnalytesDto
  {
    [JsonProperty("ID")]
    public int ID { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("code")]
    public int Code { get; set; }

    [JsonProperty("units")]
    public string Units { get; set; }
  }
}
