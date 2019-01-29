using System.Collections.Generic;
using LabAPI.DTOs;

namespace LabAPI
{
  public interface ILabotatory
  {

    TestsDto GetClassifiers(string username, string password);
    IList<OrderDto> GetOrdered(string username, string password);
    OrderedDto CreateOrder(string username, string password, PatientDto patientInfo, IList<TestsDto> testIDs);
  }
}
