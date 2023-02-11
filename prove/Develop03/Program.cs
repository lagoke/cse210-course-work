using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureReference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stores a library of scriptures instead of one
            List<Scripture> scriptureLibrary = new List<Scripture>();
            scriptureLibrary.Add(new Scripture(new Reference("John 3:16"), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
            scriptureLibrary.Add(new Scripture(new Reference("Matthew 5:16"), "In the same way, let your light shine before others, so that they may see your good works and give glory to your Father in heaven."));
            scriptureLibrary.Add(new Scripture(new Reference("Philippians 4:13"), "I can do all things through Christ who gives me strength."));

            //scripture is chosen at random from the library of scriptures
            Random random = new Random();
            int scriptureIndex = random.Next(0, scriptureLibrary.Count);
            Scripture scripture = scriptureLibrary[scriptureIndex];
            
            // Display the scripture text and hide words until no words remain
            while (scripture.GetRemainingWords() > 0)
            {
                scripture.Display();
                Console.WriteLine("Press enter to hide more words or type quit to end the program.");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                {
                    break;
                }

                scripture.HideWords();
                Console.Clear();
            }
        }
    }

    class Reference // The First class, to store scripture references
    {
        private string reference;

        public Reference(string reference)
        {
            this.reference = reference;
        }

        public string GetReference()
        {
            return reference;
        }
    }

    class Scripture // The second class, to store scripture texts
    {
        private Reference reference;
        private List<Word> words;
        private List<Word> hiddenWords;

        public Scripture(Reference reference, string text)
        {
            this.reference = reference;
            words = text.Split(' ').Select(x => new Word(x)).ToList();
            hiddenWords = new List<Word>();
        }

        public int GetRemainingWords() // Return the number of words not yet hidden
        {
            return words.Count - hiddenWords.Count;
        }

        public void Display() // Method to display the scripture
        {
            Console.WriteLine(reference.GetReference());
            foreach (Word word in words)
            {
                if (hiddenWords.Contains(word))
                {
                    Console.Write("__ ");
                }
                else
                {
                    Console.Write(word.GetWord() + " ");
                }
            }
            Console.WriteLine();
        }

        public void HideWords() // Choose a random word from the remaining words and add it to the list of hidden words
        {
            Random random = new Random();
            int wordIndex = random.Next(0, words.Count - hiddenWords.Count);
            int hiddenWordCount = 0;
            for (int i = 0; i < words.Count; i++)
            {
                if (!hiddenWords.Contains(words[i]))
                {
                    if (hiddenWordCount == wordIndex)
                    {
                        hiddenWords.Add(words[i]);
                        break;
                    }
                    hiddenWordCount++;
                }
            }
        }
    }




    class Word // The third class
    {
        private string word;


        public Word(string word)
        {
            this.word = word;
        }

        public string GetWord()


        {
            return word;
        }
    }
}