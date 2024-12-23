namespace TopInterview150;
public class LongestCommonPrefixClass
{
    public static void Run()
    {
        string solution = LongestCommonPrefix(["flower", "flow", "flight"]);
        Console.WriteLine(solution);
    }
    public static string LongestCommonPrefix(string[] strs)
    {
        int minLength = strs[0].Length;

        foreach (string s in strs)
        {
            minLength = Math.Min(minLength, s.Length);
        }

        for (int i = 0; i < minLength; i++)
        {
            char currChar = strs[0][i];
            for (int j = 0; j < strs.Length; j++)
            {

                if (strs[j][i] != currChar)
                {
                    return strs[0][..i];
                }
            }
        }
        return strs[0][..minLength];
    }
}