using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class GameLogic
    {
        public string completeWord = "sant";
        public string currentWord;
        public bool correct;
        public int errors = 0;
        public int maxErrors = 12;
        public bool alive = true;
        public char input;
        public bool completed = false;


        public void setCompletedWord(string word)
        {
            completeWord = word;
        }

        public void showWord()
        {
            Console.WriteLine($"{currentWord}");
        }

        public void checkLetter(char letter)
        {
            correct = false;
            for (var i = 0; i < completeWord.Length; i++)
            {
                if (completeWord[i] == letter && currentWord.Length >= i)
                {
                    char[] array = currentWord.ToCharArray();
                    array[i] = letter;

                    currentWord = new string(array);
                    correct = true;
                }
            }
            if (correct) Console.WriteLine("Det var riktig!");
            else
            {
                Console.WriteLine("Det var feil!");
                errors++;
            }
            Console.ReadKey();
        }

        public void checkState()
        {
            alive = true;
            if (errors >= maxErrors) alive = false; 
            if (completeWord == currentWord.ToString()) completed = true;
        }

        public void promptInput()
        {
            Console.WriteLine("Hva vil du skrive?");
            var Input = Console.ReadLine();
            input = Input[0];
        }
    }
}
