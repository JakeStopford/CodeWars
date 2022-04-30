namespace Codewars.Remove_anchor_from_URL
{
    public static class StringEndsWithQuestionMarkKata
    {
        public static bool Solution(string str, string ending)
        {
            if (str.EndsWith(ending))
            { 
                return true;
            }
            
            return false;
        }
    }
}
