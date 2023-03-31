namespace WordFlex_Program;
class Program
{
    static void Main(string[] args)
    {
        WordFlex();
        Console.ReadKey();
    }

    public static void WordFlex()
    {
        // initializing the arrays
        string[] wordsFlexA = new string[] {"Sponge", "Giggle", "Beetroot", "Watermelon"};
        string[] wordsFlexB = {"Sus", "Amogus", "Video games", "FPS"};

        Console.WriteLine("Select an exam question: A/B");
        string input = Console.ReadLine()!;
        if (input == "A" || input == "a")
        {
            for (int i = 0; i < wordsFlexA.Length; i++)
            {
                Random random = new Random(); // getting a random num
                int randomWord = random.Next(0, wordsFlexA.Length);
                Console.WriteLine(wordsFlexA[randomWord]); // Write the word corresponding to the index
                Console.WriteLine("Press enter to add a new word, press anything else to stop");
                string enter = Console.ReadLine()!;
                if (enter == "")
                {
                    continue;
                } else {break;}
            }
        }
        if (input == "B" || input == "b")
        {
            for (int i = 0; i < wordsFlexB.Length; i++)
            {
                Random random = new Random();
                int randomWord = random.Next(0, wordsFlexB.Length);
                Console.WriteLine(wordsFlexB[randomWord]);
                Console.WriteLine("Press enter to add a new word, press anything else to stop");
                string enter = Console.ReadLine()!;
                if (enter == "")
                {
                    continue;
                } else {break;}
            }
            
        }
    }
}
