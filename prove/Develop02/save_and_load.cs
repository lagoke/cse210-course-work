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


            File.Copy("myjornal.txt", "filename_passed", true);


        }



        public void load_journal(string filename)
        {

            string filename_passed = filename;
            string[] lines = System.IO.File.ReadAllLines(filename_passed);

            foreach (string line in lines)
            {
                string[] parts = line.Split("\n");

                string line_of_text1 = parts[0];
                //string line_of_text2 = parts[1];

                Console.WriteLine(line_of_text1);
                //Console.WriteLine(line_of_text2);
            }


        }




    }
    }