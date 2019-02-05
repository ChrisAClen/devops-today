using DevOpsToday.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsToday.MSTesting.Test
{
  [TestClass]
  public class HomeContollerTests
  {
      [TestMethod]
      public void Test_IndexAction()
      {
        var sut = new HomeContoller();

        Assert.IsNotNull(sut.Index());
      }

      [TestMethod]
      public void Test_PrivacyAction()
      {
        var sut = new HomeContoller();

        Assert.IsNotNull(sut.Privacy());
      }
  }
}
