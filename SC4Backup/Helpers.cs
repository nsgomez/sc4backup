using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SC4Backup
{
    class Helpers
    {
        public static DateTime GetUnixDateTimeNow()
        {
            DateTime timestamp = DateTime.Now;
            //timestamp = timestamp.AddSeconds(timestampSecs);
            timestamp = timestamp.Add(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).TimeOfDay);
            return timestamp;
        }

        public static ulong GetUnixTimestampNow()
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = GetUnixDateTimeNow().ToUniversalTime() - origin;
            return (ulong)(Math.Floor(diff.TotalSeconds));
        }
    }
}
