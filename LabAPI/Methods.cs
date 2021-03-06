﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using LabAPI.DTOs;
using Newtonsoft.Json;

namespace LabAPI.Methods
{
  public class Methods : ILabotatory
    
  {

    TestsDto ILabotatory.GetClassifiers(string username, string password)
    {
      using (HttpClient httpClient = new HttpClient())
      {
        var url = "https://staging.lyg.io/api/classifiers";
        var encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
        var response = httpClient.GetAsync(url).GetAwaiter().GetResult();
        var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        IEnumerable<TestsDto> jsonToObjects = JsonConvert.DeserializeObject<IEnumerable<TestsDto>>(result);
        //return jsonToObjects; //NEVEIKIA?
        return null;
      }
    }

    public IList<OrderDto> GetOrdered(string username, string password)
    {
      using (HttpClient httpClient = new HttpClient())
      {
        var url = "https://staging.lyg.io/api/orders";
        var encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);
        var response = httpClient.GetAsync(url).GetAwaiter().GetResult();
        var result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        IEnumerable<OrderDto> jsonToObjects = JsonConvert.DeserializeObject<IEnumerable<OrderDto>>(result);
        //return jsonToObjects; //NEVEIKIA
        return null;
      }
    }

    public OrderedDto CreateOrder(string username, string password, PatientDto patientInfo, IList<TestsDto> testIDs)
    {
      using (HttpClient httpClient = new HttpClient())
      {
        var url = "https://staging.lyg.io/api/order";
        var encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded);

        var OrderDetails = new OrderedDto
        {
          Name = patientInfo.Name,
          Surname = patientInfo.Surname,
          Bday = patientInfo.Bday,
          Sex = patientInfo.Sex,
          Classifiers = testIDs
        };

        var json = JsonConvert.SerializeObject(OrderDetails);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var result = httpClient.PostAsync(url, content).Result;

        //return result; //NEVEIKIA
        return null;


      }
    }
  }
}
