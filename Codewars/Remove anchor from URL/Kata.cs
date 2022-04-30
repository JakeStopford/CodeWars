namespace Codewars.Remove_anchor_from_URL
{
    public static class RemoveUrlAnchorKata
    {
        public static string RemoveUrlAnchor(string url)
        {
            var arr = url.Split("#");

            return arr[0];
        }
    }
}
