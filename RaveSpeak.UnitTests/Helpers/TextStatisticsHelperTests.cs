using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaveSpeak.Helpers;
using System;

namespace RaveSpeak.UnitTests.Helpers
{
    [TestClass]
    public class TextStatisticsHelperTests
    {
        private string sentence;
        private TextStatisticsHelper textStatisticsHelper;

        [TestInitialize]
        public void Initialize()
        {
            // Arrange and Act
            sentence = "the quick brown fox jumps over the lazy dog";            
            textStatisticsHelper = new TextStatisticsHelper(sentence);
        }

        [TestMethod]
        public void FleschKincaidGradeLevelTest()
        {            
            // Assert
            Assert.AreEqual(2.3, textStatisticsHelper.FleschKincaidGradeLevel);
        }

        [TestMethod]
        public void AutomatedReadabilityIndexTest()
        {
            // Assert
            Assert.AreEqual(1.4, textStatisticsHelper.AutomatedReadabilityIndex);
        }

        [TestMethod]
        public void ColemanLiauIndexTest()
        {
            // Assert
            Assert.AreEqual(7.1, textStatisticsHelper.ColemanLiauIndex);
        }

        [TestMethod]
        public void FleschKincaidReadingEaseTest()
        {
            // Assert
            Assert.AreEqual(94.3, textStatisticsHelper.FleschKincaidReadingEase);
        }

        [TestMethod]
        public void GunningFogScoreTest()
        {
            // Assert
            Assert.AreEqual(3.6, textStatisticsHelper.GunningFogScore);
        }
        
        [TestMethod]
        public void GetStatisticsReportTest()
        {
            var expectedStatisticsReport = "AutomatedReadabilityIndex: 1.4" + Environment.NewLine +
                                           "ColemanLiauIndex: 7.1" + Environment.NewLine +
                                           "FleschKincaidGradeLevel: 2.3" + Environment.NewLine +
                                           "FleschKincaidReadingEase: 94.3" + Environment.NewLine +
                                           "GunningFogScore: 3.6" + Environment.NewLine +
                                           "SMOGIndex: 1.8" + Environment.NewLine;
            // Assert
            Assert.AreEqual(expectedStatisticsReport, textStatisticsHelper.GetStatisticsReport());
        }
    }
}
