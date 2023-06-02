// See https://aka.ms/new-console-template for more information

using static System.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        string source = "Hello World!";
        SplitString(source);
    }

    static void SplitString(string source)

    {
        string[] words = source.Split(" ");
        Console.WriteLine(words.Length);

        char[] chars1 = words[0].ToCharArray();
        Console.WriteLine(chars1.Length);
        char[] chars2 = words[1].ToCharArray();
        Console.WriteLine(chars2.Length);

        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(chars);
        }
    }
}