using System;

public class Run
{
    public static int IndexOfLongestRun(string str)
    {
        var start = 0;
        var end = 0;
        var lenght = 0;
        var maxLenght = 0;
        var character = str[0];
        var count = 0;

        while (count < str.Length)
        {
            if (character == str[count])
            {
                lenght++;
            }
            else
            {
                if (lenght > maxLenght)
                {
                    start = count - lenght;
                    maxLenght = lenght;
                    end = count - 1;
                }
                character = str[count];
                lenght = 1;
            }
            count++;
        }

        return start;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IndexOfLongestRun("abbcccddddcccbba"));
    }
}