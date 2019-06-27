namespace RaveSpeak.SentimentAnalysis
{
    public class SentimentResponse
    {
        public class Rootobject
        {
            public string type { get; set; }
            public Properties properties { get; set; }
        }

        public class Properties
        {
            public Documents documents { get; set; }
            public Errors errors { get; set; }
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
            public Id id { get; set; }
            public Score score { get; set; }
        }

        public class Id
        {
            public string description { get; set; }
            public string type { get; set; }
        }

        public class Score
        {
            public string format { get; set; }
            public string description { get; set; }
            public string type { get; set; }
        }

        public class Errors
        {
            public string type { get; set; }
            public Items1 items { get; set; }
            public bool readOnly { get; set; }
        }

        public class Items1
        {
            public string type { get; set; }
            public Properties2 properties { get; set; }
        }

        public class Properties2
        {
            public Id1 id { get; set; }
            public Message message { get; set; }
        }

        public class Id1
        {
            public string description { get; set; }
            public string type { get; set; }
        }

        public class Message
        {
            public string description { get; set; }
            public string type { get; set; }
        }

    }
}
