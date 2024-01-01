using System.Text.RegularExpressions;

namespace MyPersonalBlog.Extensions;

public static class StringExtensions
{
    public static string ToSlug(this string value)
    {
        return Regex.Replace(
            Regex.Replace(value,"[^a-zA-Z0-9 ]",string.Empty),
            @"\s+",
            "-")
        .ToLowerInvariant();
    }
}