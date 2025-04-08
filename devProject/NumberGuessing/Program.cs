
namespace MathGame
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int winNum = random.Next(0, 100);
            bool win = false;
            
            do
            {
                Console.WriteLine("Guess my hidden number, 0-100");
                string guess = Console.ReadLine();
                int numberGuess = int.Parse(guess);

                if(numberGuess > winNum)
                {
                    Console.WriteLine($"{numberGuess} is too high, try lower...");
                }
                else if (numberGuess < winNum)
                {
                    Console.WriteLine($"{numberGuess} is too low, try higher...");
                }
                else if (numberGuess == winNum)
                {
                    Console.WriteLine($"You did it! My number was {winNum}");
                }
            } while (win == false);
        }
    }
}