namespace RaveSpeak.Helpers
{
    public class TextStatisticsHelper
    {
        public double AutomatedReadabilityIndex { get; set; }
        public double ColemanLiauIndex { get; set; }
        public double FleschKincaidGradeLevel { get; set; }
        public double FleschKincaidReadingEase { get; set; }
        public double GunningFogScore { get; set; }
        public double SMOGIndex { get; set; }

        public TextStatisticsHelper(string text)
        {
            var statistics = TextStatistics.TextStatistics.Calculate(text);

            AutomatedReadabilityIndex = statistics.AutomatedReadabilityIndex;
            ColemanLiauIndex = statistics.ColemanLiauIndex;
            FleschKincaidGradeLevel = statistics.FleschKincaidGradeLevel;
            FleschKincaidReadingEase = statistics.FleschKincaidReadingEase;
            GunningFogScore = statistics.GunningFogScore;
            SMOGIndex = statistics.SMOGIndex;
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
