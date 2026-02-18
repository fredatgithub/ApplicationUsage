using FluentAssertions;
using Xunit;

namespace MockDataLibrary.Tests
{
  public class TestsMockData
  {
    [Fact]
    public void Test_simple()
    {
      var resultat = 2 + 3;
      resultat.Should().Be(5);
    }
  }
}
