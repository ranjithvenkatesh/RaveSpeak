using System.Globalization;

namespace RaveSpeak.Helpers
{
    public class TextStatisticsHelper
    {
        public string AutomatedReadabilityIndex { get; set; }
        public string ColemanLiauIndex { get; set; }
        public string FleschKincaidGradeLevel { get; set; }
        public string FleschKincaidReadingEase { get; set; }
        public string GunningFogScore { get; set; }
        public string SMOGIndex { get; set; }

        public TextStatisticsHelper(string text)
        {
            var statistics = TextStatistics.TextStatistics.Calculate(text);

            AutomatedReadabilityIndex = statistics.AutomatedReadabilityIndex.ToString(CultureInfo.InvariantCulture);
            ColemanLiauIndex = statistics.ColemanLiauIndex.ToString(CultureInfo.InvariantCulture);
            FleschKincaidGradeLevel = statistics.FleschKincaidGradeLevel.ToString(CultureInfo.InvariantCulture);
            FleschKincaidReadingEase = statistics.FleschKincaidReadingEase.ToString(CultureInfo.InvariantCulture);
            GunningFogScore = statistics.GunningFogScore.ToString(CultureInfo.InvariantCulture);
            SMOGIndex = statistics.SMOGIndex.ToString(CultureInfo.InvariantCulture);
        }

        public string GetStatisticsReport()
        {
            var newLine = "\r\n";
            var statisticsReport = "AutomatedReadabilityIndex: " + AutomatedReadabilityIndex + newLine +
                                   "ColemanLiauIndex: " + ColemanLiauIndex + newLine +
                                   "FleschKincaidGradeLevel: " + FleschKincaidGradeLevel + newLine +
                                   "FleschKincaidReadingEase: " + FleschKincaidReadingEase + newLine +
                                   "GunningFogScore: " + GunningFogScore + newLine +
                                   "SMOGIndex: " + SMOGIndex + newLine;

            return statisticsReport;
        }
    }
}
