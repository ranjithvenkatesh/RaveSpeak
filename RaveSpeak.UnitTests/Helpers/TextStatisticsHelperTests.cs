using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaveSpeak.Helpers;

namespace RaveSpeak.UnitTests.Helpers
{
    [TestClass]
    public class TextStatisticsHelperTests
    {
        [TestMethod]
        public void FleschKincaidGradeLevelTest()
        {
            // Arrange and Act
            var textStatisticsHelper = new TextStatisticsHelper("the quick brown fox jumps over the lazy dog");

            // Assert
            Assert.AreEqual(2.3, textStatisticsHelper.FleschKincaidGradeLevel);
        }
    }
}
