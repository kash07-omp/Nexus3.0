namespace Nexus.Web.Services
{
    public static class DateHelper
    {
        static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static int ToUnixUtcDate(this DateTime date)
        {
            return (int)(date.ToUniversalTime() - epoch).TotalSeconds;
        }

        public static int ToUnixDate(this DateTime date)
        {
            return (int)(date - epoch).TotalSeconds;
        }
    }
}
