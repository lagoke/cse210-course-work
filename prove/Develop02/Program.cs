using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            string welcome = "Welcome to the Journal Program!";
            string msg_to_appeal = "Please select one of the following choices:";
            string first_choice = "1. Write";
            string second_choice = "2. Display";
            string third_choice = "3. Load";
            string fourth_choice = "4. Save";
            string fifth_choice = "5. Quit";

            string ask_what_to_do = "What would you like to do?";

            Console.WriteLine(welcome);
            Console.WriteLine(msg_to_appeal);
            Console.WriteLine(first_choice);
            Console.WriteLine(second_choice);
            Console.WriteLine(third_choice);
            Console.WriteLine(fourth_choice);
            Console.WriteLine(fifth_choice);
            Console.WriteLine(ask_what_to_do);

            var choice = Console.ReadLine();

           // string question_written = "";

            if (choice == "1")
            {
                Write_and_Display obj = new Write_and_Display();
                // obj.writeRandomQuestions();
                string question_written = obj.writeRandomQuestions();

                var user_response = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                string fileName = "myjornal.txt";

                //string text_to_store = "\n";

                using (StreamWriter outputFile = File.AppendText(fileName))
                {
                    // Add the question displayed to the file
                    // outputFile.WriteLine(helpful_questions.ElementAt(_someRandomjournal_question));

                    // Add the user's response to the displayed question inside the file



                    //string my_new_text = outputFile.WriteLine($"Date:  { dateText} - Prompt: \n { user_response} ").ToString();
                    //text_to_store += my_new_text;
                 outputFile.WriteLine($"Date:  { dateText} - Prompt: { question_written} \n { user_response} \n ");


                }

            }

            if (choice == "2")
            {
                Write_and_Display obj2 = new Write_and_Display();
                obj2.display_stored_question_and_answer();
            }





            if (choice == "3")
            {
               
                Console.WriteLine("What is the filename?");
                var supplied_filename = Console.ReadLine();


                Save_and_Load obj3 = new Save_and_Load();
                obj3.load_journal(supplied_filename);


                /*
                Write_and_Display obj2 = new Write_and_Display();
                obj2.display_stored_question_and_answer();
                */

            }




            if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                var supplied_filename = Console.ReadLine();


                Save_and_Load obj3 = new Save_and_Load();
                obj3.save_journal(supplied_filename);
            }



            if (choice == "5")
            {
                System.Environment.Exit(0);
            }




        }

    }
}