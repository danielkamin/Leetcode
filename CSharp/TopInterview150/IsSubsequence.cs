namespace TopInterview150;
public class IsSubsequenceClass
{
    public static void Run()
    {
        bool solution = IsSubsequence("aaaaaa", "bbaaaa");
        Console.WriteLine(solution);
    }
    public static bool IsSubsequence(string s, string t)
    {
        bool found = true;
        int shorterString = s.Length;
        for (int i = 0; i < shorterString; i++)
        {
            if (s.Length == 0)
            {
                break;
            }
            int indexOfChar = t.IndexOf(s[0]);
            if (indexOfChar == -1)
            {
                found = false;
                break;
            }
            else
            {
                t = t.Substring(indexOfChar + 1);
            }
            s = s.Substring(1);
        }
        return found;
    }
}