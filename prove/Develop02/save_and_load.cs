using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JournalApp
{
    class Save_and_Load
    {

        public void save_journal(string send_filename)
        {
            string filename_passed = send_filename;
            File.Copy("myjornal.txt", "filename_passed", true);

/*
            if (filename_passed != "")
            {
                System.IO.File.WriteAllText("myjornal.txt", filename_passed);
            }

            */

            /*
            // First retrieve the content of the present file name
            string filename = "myjornal.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("\n");

                string line_of_text1 = parts[0];
                //string line_of_text2 = parts[1];

                //Console.WriteLine(line_of_text1);
                //Console.WriteLine(line_of_text2);


                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

               // string fileName = "myjornal.txt";

                //string text_to_store = "\n";

                using (StreamWriter outputFile = new StreamWriter(filename_passed))
                {
                    // Add the question displayed to the file
                    // outputFile.WriteLine(helpful_questions.ElementAt(_someRandomjournal_question));

                    // Add the user's response to the displayed question inside the file



                    //string my_new_text = outputFile.WriteLine($"Date:  { dateText} - Prompt: \n { user_response} ").ToString();
                    //text_to_store += my_new_text;
                    outputFile.WriteLine($" { line_of_text1}");

                }


            }


            */





        }



        public void load_journal(string given_filename)
        {

            string filename_passed = given_filename;

            string filename_to_load = "myjornal.txt";
            string[] lines = System.IO.File.ReadAllLines(filename_to_load);

            foreach (string line in lines)
            {
                string[] parts = line.Split("\n");

                string line_of_text1 = parts[0];
                //string line_of_text2 = parts[1];

                Console.WriteLine(line_of_text1);
                //Console.WriteLine(line_of_text2);
            }

/*
            // Read entire text file content in one string  
            string text = File.ReadAllText(filename_passed);
            Console.WriteLine(text);

*/


            /*
            string[] lines = System.IO.File.ReadAllLines(filename_passed);

            foreach (string line in lines)
            {
                string[] parts = line.Split("\n");

                string line_of_text1 = parts[0];
                //string line_of_text2 = parts[1];

                Console.WriteLine(line_of_text1);
                //Console.WriteLine(line_of_text2);
           



        }
            */





        }




    }
    }