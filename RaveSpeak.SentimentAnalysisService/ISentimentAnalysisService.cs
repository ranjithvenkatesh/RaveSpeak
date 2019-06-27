namespace RaveSpeak.SentimentAnalysis
{
    public interface ISentimentAnalysisService
    {
        string GetSentiment(string id, string language, string text);
    }
}
