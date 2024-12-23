namespace TopInterview150;
public class IndexOfTheFirstOccurenceClass
{
    public static void Run()
    {
        int solution = IndexOfTheFirstOccurence("sadbutsad", "sad");
        Console.WriteLine(solution);
    }
    public static int IndexOfTheFirstOccurence(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            bool found = true;

            // Check if needle matches at current position
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    found = false;
                    break;
                }
            }

            if (found)
                return i;
        }

        return -1;
    }
}