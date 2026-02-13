using System;
using static MockDataLibrary.MockData;

namespace ApplicationUsage
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      Display("Mock data");
      Display("---------");
      Display("This application demonstrates the use of the MockDataLibrary to generate mock data for testing purposes.");
      Display("");
      Display("The MockDataLibrary provides a simple API to create mock data for various types, including names, addresses, phone numbers, and more. It can be used to generate realistic data for testing applications without the need for real user data.");
      Display("");
      Display($"one male first name: {GetRandomFirstName(true)}");
      Display($"one female first name: {GetRandomFirstName(false)}");
      Display($"one person first name male or female: {GetRandomFirstName()}");

      Display($"Get a random US state: {GetRandomStateWithAbbreviation()}");
      Display($"Get a random US state with abbreviation: {GetRandomStateWithAbbreviation()}");

      Display($"Get a random US city: {GetRandomCity()}");
      Display($"Get several random US cities:");
      var severalCities = GetSeveralRandomCities(5);
      for (int i = 0; i < severalCities.Count; i++)
      {
        Display($"City: {severalCities[i]}");
      }

      Display("Press any key to exit...");
      Console.ReadKey();
    }
  }
}
