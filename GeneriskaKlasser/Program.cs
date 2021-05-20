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
            Console.Clear();

            Queue<string> statsQueue = new Queue<string>();
            int argumentsEntered = 0;

            while(argumentsEntered != 3){
                if(argumentsEntered == 0){
                    Console.WriteLine("Enter your name");
                    string name = Console.ReadLine();

                    statsQueue.Enqueue(name);
                }

                if(argumentsEntered == 1){
                    Console.WriteLine("Enter your age");
                    string age = Console.ReadLine();

                    statsQueue.Enqueue(age);
                }

                if(argumentsEntered == 2){
                    Console.WriteLine("Enter your favorite video game title");
                    string game = Console.ReadLine();

                    statsQueue.Enqueue(game);
                }

                argumentsEntered++;
                Console.Clear();
            }

            Console.WriteLine("Press ENTER to view your stats.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You did pretty good for someone with the name " + statsQueue.Dequeue() + ", thats " + statsQueue.Dequeue() + " years old and likes to play " + statsQueue.Dequeue() + "...");
            Console.ReadLine();
        }
    }
}
