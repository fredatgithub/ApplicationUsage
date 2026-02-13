using System;

namespace ApplicationUsage
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      Display("Mock data");

      Display("Press any key to exit...");
      Console.ReadKey();
    }
  }
}
