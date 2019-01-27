using System;
using System.Collections.Generic;
using LabAPI.DTOs;
using LabAPI.Methods;


namespace ConsoleApp1
{
  class Program
  {
    public static void Main(string[] args)
    {
      string username = "foxlab_laskfjoi34sakljf";
      string password = "foxuslab_n0t4r4nd0mp4ss";

      var testas = new Methods();
      testas.GetClassifiers(username,password);
      testas.GetOrdered(username,password);


      var Patient = new PatientDto
      {
        Name = "Jonas",
        Surname = "Jonaitis",
        Bday = "1990-01-01",
        Sex = 1
      };

      var testIDs = new List<TestsDto>
      {
        new TestsDto {Classifier_Id = 2},
        new TestsDto {Classifier_Id = 3},
        new TestsDto {Classifier_Id = 2}
      };

      testas.CreateOrder(username, password, Patient, testIDs);

      Console.ReadLine();
    }
  }
}
