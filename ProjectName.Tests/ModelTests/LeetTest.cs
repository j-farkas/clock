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
    [TestMethod]
    public void ReplaceLeet_AnyLetter_ReturnZero()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("Don't you love these 'String' exercises? I do!");
      Assert.AreEqual('0', testLeetspeakTranslator.ReplaceLetter('o'));
    }
    [TestMethod]
    public void ReplaceLeet_AnyLetter_ReturnOne()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("Don't you love these 'String' exercises? I do!");
      Assert.AreEqual('1', testLeetspeakTranslator.ReplaceLetter('I'));
    }
    [TestMethod]
    public void ReplaceLeet_AnyLetter_ReturnSeven()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("Don't you love these 'String' exercises? I do!");
      Assert.AreEqual('7', testLeetspeakTranslator.ReplaceLetter('t'));
    }
    [TestMethod]
    public void ReplaceLeet_AnyLetter_ReturnZed()
    {
      LeetspeakTranslator testLeetspeakTranslator = new LeetspeakTranslator("Don't you love these 'String' exercises? I do!");
      Assert.AreEqual('z', testLeetspeakTranslator.ReplaceLetter('s'));
    }
  }
}
