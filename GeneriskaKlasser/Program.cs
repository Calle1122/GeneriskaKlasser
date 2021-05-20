using System;
using System.Collections.Generic;

namespace GeneriskaKlasser
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finishedWordBank = false;
            List<string> wordBank = new List<string>();
            int wordsInBank = 0;

            while(finishedWordBank == false){
                Console.WriteLine("Type words to enter them to the word bank!");
                Console.WriteLine("Type 'done' if you are finished entering words.");

                Console.WriteLine("\nWords in wordbank: " + wordsInBank);
                Console.WriteLine();

                string playerInput = Console.ReadLine();

                if(playerInput == "done"){
                    finishedWordBank = true;
                }

                else{
                    wordBank.Add(playerInput);
                    wordsInBank++;
                }

                Console.Clear();
            }

            HashSet<string> alreadyGuessedWords = new HashSet<string>();
            HashSet<string> correctGuesses = new HashSet<string>();
            
            bool doneGuessing = false;
            int numberOfCorrectGuesses = 0;

            while(doneGuessing == false){
                Console.WriteLine("Now you must try to remember and guess all the words you entered!");
                Console.WriteLine("\nCorrect guesses: " + numberOfCorrectGuesses + "/" + wordsInBank);
                Console.WriteLine();

                string playerGuess = Console.ReadLine();
                
                if(alreadyGuessedWords.Contains(playerGuess)){
                    if(correctGuesses.Contains(playerGuess)){
                        Console.WriteLine("You already guessed this word and it was correct!");
                    }

                    else{
                        Console.WriteLine("You already guessed this word and it was wrong!");
                    }
                }


                else{
                    alreadyGuessedWords.Add(playerGuess);

                    if(wordBank.Contains(playerGuess)){
                        correctGuesses.Add(playerGuess);

                        numberOfCorrectGuesses++;
                    }

                }

                Console.Clear();

                if(numberOfCorrectGuesses == wordsInBank){
                    doneGuessing = true;
                }
            }
            
            Console.WriteLine("YOU MADE IT!");
            Console.WriteLine("Before you exit the game i will show you some stats.");
            Console.WriteLine("You will have to enter some information for this to work.");
            Console.WriteLine("Press ENTER to begin...");
            Console.ReadLine();

        }
    }
}
