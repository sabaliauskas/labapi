using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace LabAPI.DTOs
{
  public class OrderDto
  {
    [JsonProperty("ID")]
    public int ID { get; set; }

    [JsonProperty("created")]
    public DateTime Created { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("surname")]
    public string Surname { get; set; }

    [JsonProperty("bday")]
    public string Bday { get; set; }

    [JsonProperty("sex")]
    public int Sex { get; set; }

    [JsonProperty("barcodes")]
    public List<BarcodesDTO> Barcodes { get; set; }

    [JsonProperty("classifiers")]
    public List<TestsDto> Classifiers { get; set; }

    [JsonProperty("status")]
    public int Status { get; set; }
  }
}
