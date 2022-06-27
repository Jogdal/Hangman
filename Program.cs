




namespace Hangman
{
    internal class Program
    {
        

        static string EnterAWord()
        {
            Console.Write("Please guess a word: ");
            string userInput = Console.ReadLine();
            return userInput.ToUpper();
        }

        static void DefineArrayWordsToGuess(string[] arr)
        {
            arr[0] = "Ship";
        }
        static void Main(string[] args)
        {
            string[] arrWords = new string[25];
            Console.WriteLine("Welcome to Hangman Game ");
            Console.WriteLine();

            // Create an Array with words for the user to Guess

            string[] arrWordsToGuess = new string[25];
            arrWordsToGuess = DefineArrayWordsToGuess(arrWords);

            string GuessedWord = EnterAWord();

            bool userGuessedWholeWord = false;
            if (GuessedWord.Length > 1)
                userGuessedWholeWord = true;

            if (userGuessedWholeWord) 
                Console.WriteLine( "You guessed the word: " + GuessedWord );
            else
                Console.WriteLine( "You guessed the letter: " + GuessedWord );
           

            Console.ReadLine();
        }
    }
}
