using System.Collections.Generic;

namespace LabAPI.DTOs
{
  public class OrderedDto
  {

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Bday { get; set; }
    public int Sex { get; set; }
    public IList<TestsDto> Classifiers { get; set; }


  }
  }

  
