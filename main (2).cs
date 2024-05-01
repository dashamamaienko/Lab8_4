using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Читання вмісту файлу
            string filePath = "/Users/dashamamaienko/Documents/example.rtf";
            char[] content = File.ReadAllText(filePath).ToLower().ToCharArray();

            // Виклик методу для обчислення кількості голосних та приголосних літер за допомогою масиву
            int vowelsCount = CountVowelsUsingArray(content);
            int consonantsCount = CountConsonantsUsingArray(content);

            Console.WriteLine("Using array:");
            Console.WriteLine("Vowels count: " + vowelsCount);
            Console.WriteLine("Consonants count: " + consonantsCount);

            // Виклик методу для обчислення кількості голосних та приголосних літер за допомогою List<T>
            vowelsCount = CountVowelsUsingList(content);
            consonantsCount = CountConsonantsUsingList(content);

            Console.WriteLine("\nUsing List<T>:");
            Console.WriteLine("Vowels count: " + vowelsCount);
            Console.WriteLine("Consonants count: " + consonantsCount);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    // Метод для обчислення кількості голосних літер за допомогою масиву
    static int CountVowelsUsingArray(char[] content)
    {
        int count = 0;
        foreach (char c in content)
        {
            if ("aeiou".IndexOf(c) != -1)
            {
                count++;
            }
        }
        return count;
    }

    // Метод для обчислення кількості приголосних літер за допомогою масиву
    static int CountConsonantsUsingArray(char[] content)
    {
        int count = 0;
        foreach (char c in content)
        {
            if ("bcdfghjklmnpqrstvwxyz".IndexOf(c) != -1)
            {
                count++;
            }
        }
        return count;
    }

    // Метод для обчислення кількості голосних літер за допомогою List<T>
    static int CountVowelsUsingList(char[] content)
    {
        int count = 0;
        foreach (char c in content)
        {
            if ("aeiou".IndexOf(c) != -1)
            {
                count++;
            }
        }
        return count;
    }

    // Метод для обчислення кількості приголосних літер за допомогою List<T>
    static int CountConsonantsUsingList(char[] content)
    {
        int count = 0;
        foreach (char c in content)
        {
            if ("bcdfghjklmnpqrstvwxyz".IndexOf(c) != -1)
            {
                count++;
            }
        }
        return count;
    }
}