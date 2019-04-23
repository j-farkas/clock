using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName;

namespace ProjectName.Tests
{
  [TestClass]
  public class PingPongTest
  {

    [TestMethod]
    public void ReplacePingPong_AnyNumber_ReturnArray()
    {
      PingPong testPingPong = new PingPong(16);
      Assert.AreEqual("2", testPingPong.ReplaceNumber(2));
    }
    [TestMethod]
    public void ReplacePingPong_AnyNumber_ReturnPing()
    {
      PingPong testPingPong = new PingPong(16);
      Assert.AreEqual("ping", testPingPong.ReplaceNumber(3));
    }
    [TestMethod]
    public void ReplacePingPong_AnyNumber_ReturnPong()
    {
      PingPong testPingPong = new PingPong(16);
      Assert.AreEqual("pong", testPingPong.ReplaceNumber(10));
    }
    [TestMethod]
    public void ReplacePingPong_AnyNumber_ReturnPingPong()
    {
      PingPong testPingPong = new PingPong(16);
      Assert.AreEqual("ping-pong", testPingPong.ReplaceNumber(15));
    }
  }
}
