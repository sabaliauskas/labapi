using Newtonsoft.Json;

namespace LabAPI.DTOs
{
  public class BarcodesDTO
  {

    [JsonProperty("ID")]
    public int ID { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("classifier_id")]
    public int Classifier_id { get; set; }
  }
}
