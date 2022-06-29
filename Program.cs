using static System.Console;



namespace Hangman
{
    internal class Program
    {

        static void PrintMenu()
        {
            Console.WriteLine("Welcome to Hangman Game ! ");
            Console.WriteLine();
            Console.WriteLine("The objective is to guess a word by entering a word or a single letter");
            Console.WriteLine("");
            // Console.WriteLine("");
            // Console.WriteLine("");

            return;
        }
        static string EnterAWord()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Please guess a word: ");
            string userInput = Console.ReadLine();
            return userInput.ToUpper();
        }

        static string[] DefineArrayWordsToGuess(string[] arr)
        {
            arr[0] = "Ship";
            arr[1] = "Submarine";
            arr[2] = "Car";
            arr[3] = "Airplane";
            arr[4] = "Bicycle";
            arr[5] = "Motorcycle";
            arr[6] = "Helicopter";
            arr[7] = "Boat";
            arr[8] = "Yacht";
            arr[9] = "House";
            arr[10] = "Chalet";
            arr[11] = "Rythm";
            arr[12] = "";
            arr[13] = "";
            arr[14] = "";
            arr[15] = "";
            arr[16] = "";
            arr[17] = "";
            arr[18] = "";
            arr[19] = "";
            arr[20] = "";
            arr[21] = "";
            arr[22] = "";
            arr[23] = "";
            arr[24] = "";

            return arr;
        }

        static void PrintGuesses(string[] lettersInRandomWord, string[] guessedLetters, string RandomWord)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = 0; i < RandomWord.Length; i++)
            {
                // Console.Write(lettersInRandomWord[i] + " ");
                Console.Write(guessedLetters[i] + " ");
            }
            return;
        }

        static void MainGuessFunction()
        {

        }


        static void Main(string[] args)
        {
            int maxGuesses = 10;
            int nrOfGuesses = 0;
            int guessesLeft = maxGuesses;
            string[] arrWords = new string[25];
            string wrongGuesses = "";
            Clear();

            PrintMenu();

            // Create an Array with words for the user to Guess
            string[] arrWordsToGuess = new string[25];
            arrWordsToGuess = DefineArrayWordsToGuess(arrWords);
            Random rnd = new Random();
            int num = rnd.Next(0, 11);
            // Console.WriteLine(arrWords[num]);


            string RandomWord = arrWords[num].ToUpper();
            // string RandomWord = arrWords[5].ToUpper();


            string GuessedWord = "";
            bool UserGuessedWord = false;
            bool userGuessedWholeWord = false;

            int WordLength = RandomWord.Length;

            // Console.WriteLine(RandomWord);
            // Console.WriteLine(WordLength);
            // Console.WriteLine();

            string[] lettersInRandomWord = new string[RandomWord.Length];
            string[] guessedLetters = new string[RandomWord.Length];

            for (int i = 0; i < RandomWord.Length; i++)
            {
                lettersInRandomWord[i] = "_";
                guessedLetters[i] = "_";
            }

            // PrintGuesses(lettersInRandomWord , guessedLetters, RandomWord);

            // Console.WriteLine();


            do
            {

                GuessedWord = EnterAWord();
                nrOfGuesses++;
                guessesLeft--;

                // Console.WriteLine(GuessedWord);


                if (GuessedWord.Length > 1)
                {
                    userGuessedWholeWord = true;
                    if (GuessedWord == RandomWord)
                    {
                        // Console.WriteLine("Congrats , You guessed the right word " + RandomWord + " in " + nrOfGuesses);
                        UserGuessedWord = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        PrintGuesses(lettersInRandomWord, guessedLetters, RandomWord);
                        Console.WriteLine();
                        Console.WriteLine("Wrong guess , " + guessesLeft + " guesses left!");
                        Console.WriteLine();
                    }
                }

                if (GuessedWord.Length == 1)
                {
                    // Console.WriteLine("en bokstav " + GuessedWord);
                    // Console.WriteLine(RandomWord);
                    // Console.WriteLine();

                    char guessedLetter = (char)GuessedWord[0];
                    int plats = 0;
                    bool wrongGuess = true;
                    for (int i = 0; i < RandomWord.Length; i++)
                    {
                        // Console.WriteLine( GuessedWord + " " + RandomWord[i]);

                        if (RandomWord[i] == guessedLetter)
                        {
                            plats = i + 1;
                            // Console.WriteLine(GuessedWord + " finns i ordet på " + plats + "plats");
                            guessedLetters[i] = GuessedWord;
                            wrongGuess = false;
                        }

                        // If you guessed wrong //

                    }
                    Console.WriteLine();

                    if (wrongGuess)
                    {
                        wrongGuesses = wrongGuesses + guessedLetter;
                        Console.WriteLine(guessedLetter + " was wrong! ");

                    }

                    Console.WriteLine("Your guesses: " + wrongGuesses);
                    Console.WriteLine(guessesLeft + " guesses left.");
                    Console.WriteLine();

                    PrintGuesses(lettersInRandomWord, guessedLetters, RandomWord);
                    Console.WriteLine();
                    string finalWord = "";
                    for (int i = 0; i < RandomWord.Length; i++)
                        finalWord = finalWord + guessedLetters[i];

                    if (finalWord == RandomWord)
                        UserGuessedWord = true;

                    // Console.WriteLine(finalWord + " " + nrOfGuesses + " " + UserGuessedWord);

                }
            } while (!UserGuessedWord && nrOfGuesses < maxGuesses);

            if (UserGuessedWord)
                Console.WriteLine("Congratulations! You guessed the right word in " + nrOfGuesses + " attempts!");
            else
                Console.WriteLine("You failed , the right guess would have been " + RandomWord);

            Console.ReadLine();
        }
    }
}