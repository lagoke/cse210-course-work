using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Mindfulness
{
    class Program
    {

        public class Mindfulness
        {

            private string _nameOfActivity;
            private string _descriptionOfActivity;
            private string _durationOfActivity;
            private string _endingMessage;

            public Mindfulness(string nameOfActivity, string descriptionOfActivity, string durationOfActivity, string endingMessage)
            {
                _nameOfActivity = nameOfActivity;
                _descriptionOfActivity = descriptionOfActivity;
                _durationOfActivity = durationOfActivity;
                _endingMessage = endingMessage;
            }

            // Create Getters for private member variables for easy accessibility

            public string GetNameOfActivity()
            {
                return _nameOfActivity;
            }

            public string GetDescriptionOfActivity()
            {
                return _descriptionOfActivity;
            }

            public string GetDurationOfActivity()
            {
                return _durationOfActivity;
            }


            public string GetEndingMessage()
            {
                return _endingMessage;
            }

            public string GetSummary()
            {
                return "Welcome to the " + _nameOfActivity + "\n" + _descriptionOfActivity + "\n" + _durationOfActivity;
            }



        }





        //BreathingActivity class inheriting from the Mindfulness class
        public class BreathingActivity : Mindfulness
        {

            private string[] _breathingExercise;

            // The constructor for BreathingActivity
            public BreathingActivity(string nameOfActivity, string descriptionOfActivity, string durationOfActivity, string endingMessage, string[] breathingExercise)
                : base(nameOfActivity, descriptionOfActivity, durationOfActivity, endingMessage)
            {
                // These are member variables of the BreathingActivity class
                _breathingExercise = breathingExercise;

            }

            public string[] GetBreathingExercise()
            {
                return _breathingExercise;
            }


            public void ShowBreathingMsg()
            {

                int count_length = _breathingExercise.Length;
                Console.Write(_breathingExercise[0]);

               // Console.WriteLine("This text stays here");
                for (int a = 3; a >= 0; a--)
                {
                    Console.Write(a);
                    System.Threading.Thread.Sleep(1000);
                }

                Console.WriteLine("\n");

                Console.Write(_breathingExercise[1]);

                // Console.WriteLine("This text stays here");
                for (int a = 3; a >= 0; a--)
                {
                    Console.Write(a);
                    System.Threading.Thread.Sleep(1000);
                }

                Console.WriteLine("\n");

                // Console.WriteLine(count_length);

            /*
                //Loop through the Breath in and Breath out
                for (int counter=0; counter < count_length  - 1; counter++)
                {

                   // Console.WriteLine(_breathingExercise[counter]);

                   // Thread.Sleep(3000);

                }
               

                */
               
            }


        }



        //ReflectionActivity class inheriting from the Mindfulness class
        public class ReflectionActivity : Mindfulness
        {

           

            private string _listOfRandomPrompts;
            private int _sampleRandomPrompt;
            private string _listOfReflectQuestions;
            private int _sampleReflectQuestions;

            // The constructor for ReflectionActivity
            public ReflectionActivity(string nameOfActivity, string descriptionOfActivity, string durationOfActivity, string endingMessage)
                : base(nameOfActivity, descriptionOfActivity, durationOfActivity, endingMessage)
            {
                // These are member variables of the ReflectionActivity class
                //_listOfRandomPrompts = listOfRandomPrompts;

            }

            public string GetListOfRandomPrompts()
            {
                return _listOfRandomPrompts;
            }


            public int GetSampleRandomPrompt()
            {
                return _sampleRandomPrompt;
            }







            public string DisplayRandomPrompts()
            {

                List<string> _listOfRandomPrompts = new List<string>();

                _listOfRandomPrompts.Add("--- Think of a time when you stood up for someone else. ---");
                _listOfRandomPrompts.Add("--- Think of a time when you did something really difficult. ---");
                _listOfRandomPrompts.Add("--- Think of a time when you helped someone in need. ---");
                _listOfRandomPrompts.Add("--- Think of a time when you did something truly selfless. ---");

                Random R = new Random();

                // get random number from 0 to 2.
                _sampleRandomPrompt = R.Next(0, _listOfRandomPrompts.Count());

                Console.WriteLine(" {0}", _listOfRandomPrompts.ElementAt(_sampleRandomPrompt));

                return _listOfRandomPrompts.ElementAt(_sampleRandomPrompt);


            }



            public string DisplayRandomReflectQuestions()
            {

                List<string> _listOfReflectQuestions = new List<string>();

                _listOfReflectQuestions.Add(" > Why was this experience meaningful to you?");
                _listOfReflectQuestions.Add(" > Have you ever done anything like this before?");
                _listOfReflectQuestions.Add(" > How did you get started?");
                _listOfReflectQuestions.Add(" > How did you feel when it was complete?");
                _listOfReflectQuestions.Add(" > What made this time different than other times when you were not as successful?");
                _listOfReflectQuestions.Add(" > What is your favorite thing about this experience?");
                _listOfReflectQuestions.Add(" > What could you learn from this experience that applies to other situations?");
                _listOfReflectQuestions.Add(" > What did you learn about yourself through this experience?");
                _listOfReflectQuestions.Add(" > How can you keep this experience in mind in the future?");

                Random R = new Random();

                // get random number from 0 to 2.
                _sampleReflectQuestions = R.Next(0, _listOfReflectQuestions.Count());

                Console.Write(" {0}", _listOfReflectQuestions.ElementAt(_sampleReflectQuestions));

                return _listOfReflectQuestions.ElementAt(_sampleReflectQuestions);


            }




        }







        //ListingActivity class inheriting from the Mindfulness class
        public class ListingActivity : Mindfulness
        {

            private string _listOfRandomPromptsForListing;
            private int _sampleRandomPromptForListing;


            // The constructor for ListingActivity
            public ListingActivity(string nameOfActivity, string descriptionOfActivity, string durationOfActivity, string endingMessage)
                : base(nameOfActivity, descriptionOfActivity, durationOfActivity, endingMessage)
            {
                // These are member variables of the ListingActivity class
                //_listOfRandomPromptsForListing = listOfRandomPromptsForListing;

            }

            public string GetlistOfRandomPromptsForListing()
            {
                return _listOfRandomPromptsForListing;
            }


            public int GetSampleRandomPromptForListing()
            {
                return _sampleRandomPromptForListing;
            }







            public string DisplayRandomPromptsForListing()
            {

                List<string> _listOfRandomPromptsForListing = new List<string>();

                _listOfRandomPromptsForListing.Add("--- Who are people that you appreciate? ---");
                _listOfRandomPromptsForListing.Add("--- What are personal strengths of yours? ---");
                _listOfRandomPromptsForListing.Add("--- Who are people that you have helped this week? ---");
                _listOfRandomPromptsForListing.Add("--- When have you felt the Holy Ghost this month? ---");
                _listOfRandomPromptsForListing.Add("--- Who are some of your personal heroes? ---");

                Random R = new Random();

                // get random number from 0 to 2.
                _sampleRandomPromptForListing = R.Next(0, _listOfRandomPromptsForListing.Count());

                Console.WriteLine(" {0}", _listOfRandomPromptsForListing.ElementAt(_sampleRandomPromptForListing));

                return _listOfRandomPromptsForListing.ElementAt(_sampleRandomPromptForListing);


            }






        }




        public class ConsoleSpinner
        {
            static string[,] sequence = null;

            public int Delay { get; set; } = 200;

            int totalSequences = 0;
            int counter;

            public ConsoleSpinner()
            {
                counter = 0;
                sequence = new string[,] {
                { "/", "-", "\\", "|" },
                { ".", "o", "0", "o" },
                { "+", "x","+","x" },
                { "V", "<", "^", ">" },
                { ".   ", "..  ", "... ", "...." },
                { "=>   ", "==>  ", "===> ", "====>" },
               // ADD YOUR OWN CREATIVE SEQUENCE HERE IF YOU LIKE
            };

                totalSequences = sequence.GetLength(0);
            }

            /// <summary>
            ///
            /// </summary>
            /// <param name="sequenceCode"> 0 | 1 | 2 |3 | 4 | 5 </param>
            public void Turn(string displayMsg = "", int sequenceCode = 0)
            {
                counter++;

                Thread.Sleep(Delay);

                sequenceCode = sequenceCode > totalSequences - 1 ? 0 : sequenceCode;

                int counterValue = counter % 4;

                string fullMessage = displayMsg + sequence[sequenceCode, counterValue];
                int msglength = fullMessage.Length;

                Console.Write(fullMessage);

                Console.SetCursorPosition(Console.CursorLeft - msglength, Console.CursorTop);
            }
        }

        static void Main(string[] args)
        {


            string heading = "Menu Options:";
            string first_option = "1. Start Breathing activity";
            string second_option = "2. Start Reflecting activity";
            string third_option = "3. Start Listing activity";
            string fourth_option = "4. Quit";


            string ask_what_to_do = "Select a choice from the Menu:";

            Console.WriteLine(heading);
            Console.WriteLine(first_option);
            Console.WriteLine(second_option);
            Console.WriteLine(third_option);
            Console.WriteLine(fourth_option);
            Console.WriteLine(ask_what_to_do);

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                string activityName = "Breathing Activity";
                string specificDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
              string duration = "How long, in seconds would you like for your session?";
                string endMessage = "Well Done!!";
                // Create a base Mindfulness object
                Mindfulness mindObject = new Mindfulness(activityName, specificDescription, duration, endMessage);
                Console.WriteLine(mindObject.GetSummary());

                var duration_from_user = int.Parse(Console.ReadLine());



                Console.WriteLine("Get ready...");

                string[] breathingExerciseMsg = {"Breath in...", "Now Breath out..."};

                BreathingActivity breathObject = new BreathingActivity(activityName, specificDescription, duration, endMessage, breathingExerciseMsg);
                /*
                                ConsoleSpinner spinner = new ConsoleSpinner();
                                spinner.Delay = 300;
                                while (true)
                                {
                                    spinner.Turn(displayMsg: "Working ", sequenceCode: 5);
                                }
                */

                //Console.Write("Loading");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(">");
                }

                Console.WriteLine("\n");

                Thread.Sleep(500);

                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(duration_from_user);


                DateTime currentTime = DateTime.Now;


                // Console.Write(currentTime);
               // if (currentTime < futureTime)
               // {

                   // breathObject.ShowBreathingMsg();
               // }



                for(int count_time = 0; currentTime < futureTime; count_time++)
                {

                    currentTime = currentTime.AddSeconds(count_time);

                    breathObject.ShowBreathingMsg();

                    if (currentTime == futureTime)
                    {
                        break;

                    }

                }

               
                    Console.WriteLine(mindObject.GetEndingMessage());

                    Console.WriteLine($"You have completed another {duration_from_user} seconds of the Breathing Activity.");
                //Console.Write("Loading");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(">");
                }

            }




            // If choice is 2

            if (choice == "2")
            {
                string activityName = "Reflection Activity";
                string specificDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                string duration = "How long, in seconds would you like for your session?";
                string endMessage = "Well Done!!";
                // Create a base Mindfulness object
                Mindfulness mindObject = new Mindfulness(activityName, specificDescription, duration, endMessage);
                Console.WriteLine(mindObject.GetSummary());

                var duration_from_user = int.Parse(Console.ReadLine());



                Console.WriteLine("Get ready...");

               

                ReflectionActivity reflectObject = new ReflectionActivity(activityName, specificDescription, duration, endMessage);


                //Console.Write("Loading");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(">");
                }

                Console.WriteLine("\n");

                Thread.Sleep(500);

                Console.WriteLine("Consider the following prompt:");

                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(duration_from_user);


                DateTime currentTime = DateTime.Now;


                // Console.Write(currentTime);
                // if (currentTime < futureTime)
                // {

                // breathObject.ShowBreathingMsg();
                // }



                for (int count_time = 0; currentTime < futureTime; count_time++)
                {

                    currentTime = currentTime.AddSeconds(count_time);

                    Console.WriteLine("\n");

                    reflectObject.DisplayRandomPrompts();

                    Console.WriteLine("When you have something in mind, press enter to continue");

                    // var accept_enter_from_user = Console.ReadLine();

                    Console.ReadKey();

                    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");

                    Console.Write("You may begin in ");

                    // Console.WriteLine("This text stays here");
                    for (int a = 5; a >= 0; a--)
                    {
                        Console.Write(a);
                        System.Threading.Thread.Sleep(1000);
                    }

                    Console.WriteLine("\n");

                    reflectObject.DisplayRandomReflectQuestions();

                    //Console.Write("Loading");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(">");
                    }


                    Console.WriteLine("\n");

                    reflectObject.DisplayRandomReflectQuestions();
                    //Console.Write("Loading");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(">");
                    }

                   

                    if (currentTime == futureTime)
                    {
                        break;

                    }

                }

                Console.WriteLine("\n");
                Console.WriteLine(mindObject.GetEndingMessage());

                Console.WriteLine($"You have completed another {duration_from_user} seconds of the Reflection Activity.");





            }





            //Listing Activity
            // If choice is 3

            if (choice == "3")
            {
                string activityName = "Listing Activity";
                string specificDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                string duration = "How long, in seconds would you like for your session?";
                string endMessage = "Well Done!!";
                // Create a base Mindfulness object
                Mindfulness mindObject = new Mindfulness(activityName, specificDescription, duration, endMessage);
                Console.WriteLine(mindObject.GetSummary());

                var duration_from_user = int.Parse(Console.ReadLine());



                Console.WriteLine("Get ready...");


               

                ListingActivity listingObject = new ListingActivity(activityName, specificDescription, duration, endMessage);


                //Console.Write("Loading");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(">");
                }

                Console.WriteLine("\n");

                Thread.Sleep(500);

                Console.WriteLine("List as many responses you can to the following prompt:");

                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(duration_from_user);


                DateTime currentTime = DateTime.Now;


                // Console.Write(currentTime);
                // if (currentTime < futureTime)
                // {

                // breathObject.ShowBreathingMsg();
                // }

                Console.WriteLine("\n");

                listingObject.DisplayRandomPromptsForListing();

                Console.Write("You may begin in ");

                // Console.WriteLine("This text stays here");
                for (int a = 5; a >= 0; a--)
                {
                    Console.Write(a);
                    System.Threading.Thread.Sleep(1000);
                }

                Console.WriteLine("\n");


                int total_no_of_user_list = 0;

                for (int count_time = 0; currentTime < futureTime; count_time++)
                {

                    currentTime = currentTime.AddSeconds(count_time);

                   
                    Console.Write(">");

                    var list_from_user = Console.ReadLine();

                    total_no_of_user_list = total_no_of_user_list + 1;


                    if (currentTime == futureTime)
                    {
                        break;

                    }

                }
               
                Console.WriteLine($"You listed {total_no_of_user_list} item(s)!");

                Console.WriteLine("\n");
                Console.WriteLine(mindObject.GetEndingMessage());

                Console.WriteLine($"You have completed another {duration_from_user} seconds of the Listing Activity.");



            }





            //Quit
            // If choice is 4

            if (choice == "4")
            {

                System.Environment.Exit(0);

            }



        }
        }
}