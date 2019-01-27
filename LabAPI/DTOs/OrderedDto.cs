using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace LabAPI.DTOs
{
  public class OrderedDto
  {

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Bday { get; set; }
    public int Sex { get; set; }
    public List<TestsDto> Classifiers { get; set; }
      
 }
}
  
