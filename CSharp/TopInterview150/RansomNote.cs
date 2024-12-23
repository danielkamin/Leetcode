namespace TopInterview150;
public class RansomNoteClass
{
    public static void Run()
    {
        bool solution = RansomNote("aa", "aab");
        Console.WriteLine(solution);
    }
    public static bool RansomNote(string ransomNote, string magazine)
    {
        int[] letters = new int[26];
        for (int i = 0; i < magazine.Length; i++)
        {
            letters[magazine[i] - 'a']++;
        }
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (letters[ransomNote[i] - 'a'] == 0)
            {
                return false;
            }
            letters[ransomNote[i] - 'a']--;
        }
        return true;
    }
}