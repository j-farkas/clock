using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName;

namespace ProjectName.Tests
{
  [TestClass]
  public class LeetSpeakTranslatorTest
  {

    [TestMethod]
    public void ReplaceLeet_AnyLetter_ReturnLetter()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("Don't you love these 'String' exercises? I do!");
      Assert.AreEqual('q', testLeetspeakTranslator.ReplaceLetter('q'));
    }
    [TestMethod]
    public void ReplaceLeet_AnyLetter_ReturnThree()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("Don't you love these 'String' exercises? I do!");
      Assert.AreEqual('3', testLeetspeakTranslator.ReplaceLetter('e'));
    }
  }
}
