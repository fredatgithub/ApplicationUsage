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




      Display("Press any key to exit...");
      Console.ReadKey();
    }
  }
}
