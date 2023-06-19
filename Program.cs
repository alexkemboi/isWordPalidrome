using System;
class Program
{ static bool isPalidrome(string palidrome)
    {
        string modifiedWord = RemoveSpacesPunctuationMarks(palidrome);
        modifiedWord = modifiedWord.ToLower();
        int left =0;
        int right = modifiedWord.Length - 1;
        while (left < right)
        {
            if (modifiedWord[left] != modifiedWord[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    static string RemoveSpacesPunctuationMarks(string text)
    {
        string pattern = "[^a-zA-Z0-9]";
        string replacement = "";
        return System.Text.RegularExpressions.Regex.Replace(text, pattern, replacement);

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Write a word");
        string word=Console.ReadLine();
        bool solution = isPalidrome(word);
        if (solution)
        {
            Console.Write("The word entered is a palidrome");
        }
        else
        {
            Console.Write("The word entered is not a palidrome");
        }
    }
}