using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DotMissing.String
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static string Repeat(this string str, int count)
        {
            return string.Concat(Enumerable.Repeat(str, count));
        }

        public static ICollection<string> ToChunks(this string str, int chunkSize)
        {
            Collection<string> c = new Collection<string>();
            if (str != null)
            {
                int cnt = 0;
                StringBuilder sb = new StringBuilder();
                foreach (char ch in str)
                {
                    sb.Append(ch);
                    if (++cnt == chunkSize)
                    {
                        cnt = 0;
                        c.Add(sb.ToString());
                        sb.Clear();
                    }
                }
                if (cnt > 0) { c.Add(sb.ToString()); }
            }
            return c;
        }
    }
}
