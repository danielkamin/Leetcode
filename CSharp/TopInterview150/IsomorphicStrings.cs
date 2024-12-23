namespace TopInterview150;
public class IsomorphicStringsClass
{
    public static void Run()
    {
        bool solution = IsomorphicStrings("13", "42");
        Console.WriteLine(solution);
    }
    public static bool IsomorphicStrings(string s, string t)
    {
        char[] sToT = new char[256];
        char[] tToS = new char[256];

        for (int i = 0; i < s.Length; i++)
        {
            char charS = s[i];
            char charT = t[i];

            if (sToT[charS] == 0)
            {
                if (tToS[charT] != 0)
                    return false;

                sToT[charS] = charT;
                tToS[charT] = charS;
            }
            else if (sToT[charS] != charT)
            {
                return false;
            }
        }
        return true;
    }
}