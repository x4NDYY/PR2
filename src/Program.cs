using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку (не более 20 символов): ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Строчка пустая! Повторите попытку!");
            return;
        }

        if (input.Length > 20)
        {
            Console.WriteLine("Слишком длинная строка! Повторите попытку!");
            return;
        }

        string result = ReplaceSpacesWithMostFrequent(input);
        Console.WriteLine(result);
    }

    static string ReplaceSpacesWithMostFrequent(string input)
    {
        char symbol = '\0';
        int maxCountSymbol = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char current = input[i];
            int count = 0;

            if (current == ' ')
                continue;

            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == current)
                    count++;
            }

            if (maxCountSymbol < count)
            {
                maxCountSymbol = count;
                symbol = current;
            }
        }

        if (symbol == '\0')
        {
            return "В строке только пробелы.";
        }

        return input.Replace(' ', symbol);
    }
}
