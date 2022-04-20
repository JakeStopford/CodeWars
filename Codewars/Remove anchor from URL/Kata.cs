namespace Codewars.Remove_anchor_from_URL
{
    public static class Kata
    {
        public static string RemoveUrlAnchor(string url)
        {
            if (!url.Contains("#"))
            {
                return url;
            }

            var arr = url.Split("#");

            return arr[0];
        }
    }
}
