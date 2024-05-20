internal class DailyByte
{
// Function that reverses the entered string
    static void Day1()
    {
        string[] words;
        string answer = "";
        char[] support;
        char firstElement;

        Console.Write("Enter string to reverse: ");
        try
        {
            words = Console.ReadLine().Split(" ");
        }
        catch
        {
            Console.WriteLine("Error!!!");
            return;
        }
        
        if (words is not null)
        {
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                support = words[i].ToCharArray();
                for (int j = 0; j < support.Length / 2; j++)
                {
                    firstElement = support[j];
                    support[j] = support[support.Length - 1 - j];
                    support[support.Length - 1 - j] = firstElement;
                }
                answer += new string(support) + " ";
            }
        }
        Console.WriteLine(answer);
    }

// Function that checks whether the entered string is a palindrome
    static int Day2()
    {
        string palindrome = "";

        Console.Write("Enter string to try if it a palindrome: ");
        try
        {
            palindrome = Console.ReadLine().Replace(" ", "").ToLower();
        }
        catch
        {
            Console.WriteLine("Error!!!");
        }

        if (palindrome is not null)
        {
            for (int i = 0; i < palindrome.Length / 2; i++)
            {
                if (palindrome[i] != palindrome[palindrome.Length - i - 1])
                {
                    Console.WriteLine("Entered value isn't palindrome.");
                    return 1;
                }
            }
            Console.WriteLine("Entered value is palindrome.");
            return 0;
        }
        Console.WriteLine("Entered value is empty.");
        return 0;
    }

// Function that checks if the vacuum has returned to its starting position
    static bool Day3()
    {
        int number = 0;
        string vacuum = "";

        Console.Write("Enter vacuum moves (u,r,d,l): ");
        try
        {
            vacuum = Console.ReadLine().ToLower();
        }
        catch
        {
            Console.WriteLine("Error!!!");
        }
        
        for (int i = 0; i < vacuum.Length; i++)
        {
            if (vacuum[i] == 'u' || vacuum[i] == 'r')
            {
                number++;
            }
            else if (vacuum[i] == 'd' || vacuum[i] == 'l')
            {
                number--;
            }
        }

        if (number == 0)
        {
            Console.WriteLine("True");
            return true;
        }
        else
        {
            Console.WriteLine("False");
            return false;
        }
    }

// Function that checks if entered string has properly used capitalization
    static void Day4()
    {
        string letter = "";
        bool isCorrect = true;

        Console.Write("Enter string to checks if it's has properly used capitalization: ");
        try
        {
            letter = Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Error!!!");
        }

        for (int i = 1; i < letter.Length; i++)
        {
            if (Char.IsUpper(letter, i))
            {
                isCorrect = false;
                break;
            }
        }

        if (isCorrect)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    static void Main(string[] args)
    {
        int a = -1;

        Console.Write("Which day to compile from DailyByte challenge?: ");
        try
        {
            a = Convert.ToInt32(Console.ReadLine());
        }
        catch 
        {
            Console.WriteLine("Error!!! You entered an incorrect value.");
        }

        switch (a) 
        {
            case 1:
                Day1();
                break;
            case 2:
                Day2();
                break;
            case 3:
                Day3();
                break;
            case 4:
                Day4();
                break;
            default:
                Console.WriteLine("That daily challenge isn't done.");
                break;
        }
    }
}