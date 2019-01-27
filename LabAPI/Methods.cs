using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using LabAPI.DTOs;
using Newtonsoft.Json;

namespace LabAPI.Methods
{
  public class Methods

  {
    public async void GetClassifiers(string username, string password)
    {
      var url = "https://staging.lyg.io/api/classifiers";
      var encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
      var request = (HttpWebRequest) WebRequest.Create(url);
      request.Headers.Add("Authorization", "Basic " + encoded);
      using (var response = (HttpWebResponse) await request.GetResponseAsync())
      using (var stream = response.GetResponseStream())
      using (var reader = new StreamReader(stream))
      {
        var jsonString = await reader.ReadToEndAsync();
        var jsonToObjects = JsonConvert.DeserializeObject<IEnumerable<TestsDto>>(jsonString);
      }
    }

    public async void GetOrdered(string username, string password)
    {
      var url = "https://staging.lyg.io/api/orders";
      var encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
      var request = (HttpWebRequest) WebRequest.Create(url);
      request.Headers.Add("Authorization", "Basic " + encoded);
      using (var response = (HttpWebResponse) await request.GetResponseAsync())
      using (var stream = response.GetResponseStream())
      using (var reader = new StreamReader(stream))
      {
        var jsonString = await reader.ReadToEndAsync();
        var jsonToObjects = JsonConvert.DeserializeObject<IEnumerable<OrderDto>>(jsonString);
      }
    }

    public async void CreateOrder(string username, string password, PatientDto patientInfo,
      List<TestsDto> testIDs)
    {
      var url = "https://staging.lyg.io/api/order";
      var encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

      using (var httpClient = new HttpClient())
      {
        using (var request = new HttpRequestMessage(new HttpMethod("POST"), url))
        {
          request.Headers.Add("Authorization", "Basic " + encoded);

          var OrderDetails = new OrderedDto
          {
            Name = patientInfo.Name,
            Surname = patientInfo.Surname,
            Bday = patientInfo.Bday,
            Sex = patientInfo.Sex,
            Classifiers = testIDs
          };

          var json = JsonConvert.SerializeObject(OrderDetails);

          request.Content = new StringContent(json, Encoding.UTF8, "application/json");

          var atsakymas = await httpClient.SendAsync(request);
        }
      }
    }
}
}