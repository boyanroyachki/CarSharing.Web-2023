namespace ToolsLibrary
{
    public static class Locations
    {
        private static readonly Random _rand = new Random();

        public static string GetRandomCoordinates()
        {
            double latitude = _rand.NextDouble() * (90.0 - -90.0) + -90.0;
            double longitude = _rand.NextDouble() * (180.0 - -180.0) + -180.0;

            return $"Latitude: {latitude}, Longitude: {longitude}";
        }
    }
}
