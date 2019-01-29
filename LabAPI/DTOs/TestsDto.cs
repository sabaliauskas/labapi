using System.Collections.Generic;
using Newtonsoft.Json;

namespace LabAPI.DTOs
{
  public class TestsDto
  {
    [JsonProperty("ID")] public int Classifier_Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("analytes")]
    public List<AnalytesDto> Analytes { get; set; }

  }
}

