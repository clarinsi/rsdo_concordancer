using System;

namespace Rsdo.Concordancer.Core.Constants;

public static class Cache
{
    public static class Duration
    {
        public static TimeSpan Short => TimeSpan.FromHours(1);

        public static TimeSpan Long => TimeSpan.FromDays(7);
    }

    public static class CacheKeys
    {
        public static class Msd
        {
            private const string Prefix = nameof(Msd);

            public static string ByCode(string code)
            {
                return $"{Prefix}_{nameof(ByCode)}_{code}";
            }
        }

        public static class Tokenizer
        {
            private const string Prefix = nameof(Tokenizer);

            public static string ByQuery(string query)
            {
                return $"{Prefix}_{nameof(ByQuery)}_{query}";
            }
        }
    }
}