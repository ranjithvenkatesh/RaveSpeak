namespace RaveSpeak.SentimentAnalysis
{
    public class SentimentRequest
    {
        public class Rootobject
        {
            public string type { get; set; }
            public Properties properties { get; set; }
            public string example { get; set; }
        }

        public class Properties
        {
            public Documents documents { get; set; }
        }

        public class Documents
        {
            public string type { get; set; }
            public Items items { get; set; }
            public bool readOnly { get; set; }
        }

        public class Items
        {
            public string type { get; set; }
            public Properties1 properties { get; set; }
        }

        public class Properties1
        {
            public Language language { get; set; }
            public Id id { get; set; }
            public Text text { get; set; }
        }

        public class Language
        {
            public string description { get; set; }
            public string type { get; set; }
        }

        public class Id
        {
            public string description { get; set; }
            public string type { get; set; }
        }

        public class Text
        {
            public string type { get; set; }
        }

    }
}
