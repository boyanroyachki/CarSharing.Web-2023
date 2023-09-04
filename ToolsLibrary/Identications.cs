namespace ToolsLibrary
{
    public static class Identications
    {
        public static Guid RandomGuid() => Guid.NewGuid();
        public static string RandomStringGuid() => Guid.NewGuid().ToString();
    }
}