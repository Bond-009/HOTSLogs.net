namespace HOTSLogs
{
    internal static class Endpoints
    {
        public const string BaseUrl = "https://api.hotslogs.com";
        private const string Public = "/Public";
        private const string Data = Public + "/Data";
        public const string Heroes = Data + "/Heroes";
        public const string Maps = Data + "/Maps";
        public const string Events = Public + "/Events";
        public const string Players = Public + "/Players";
    }
}
