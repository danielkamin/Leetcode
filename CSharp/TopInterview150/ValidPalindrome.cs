namespace TopInterview150;
public class ValidPalindromeClass
{
    public static void Run()
    {
        bool solution = ValidPalindrome("race a car");
        Console.WriteLine(solution);
    }
    public static bool ValidPalindrome(string s)
    {
        char[] chars = s.ToLower().Where(char.IsLetterOrDigit).ToArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (i > (chars.Length - 1) / 2)
            {
                break;
            }
            if (chars[i] != chars[chars.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}