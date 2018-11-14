using Microsoft.VisualStudio.TestTools.UnitTesting; //Imports the packages from the csproj file
using Calendar; // imports the namespace from the Calendar project

namespace Calendar.Tests
{
  [TestClass] // Tells the MSTest package to run the code contained here
  public class LeapYearTest
  {
    [TestMethod] // Tells the compiler that this code should be run by MSTest
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      // testing code will go here
    }
  }
}
