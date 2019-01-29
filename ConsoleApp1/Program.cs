using System;
using System.Collections.Generic;
using LabAPI.DTOs;
using LabAPI;
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

      ((ILabotatory)testas).GetClassifiers(username,password);
      ((ILabotatory)testas).GetOrdered(username, password);
      ((ILabotatory)testas).CreateOrder(username,password,Patient,testIDs);

      Console.ReadLine();
    }
  }
}
