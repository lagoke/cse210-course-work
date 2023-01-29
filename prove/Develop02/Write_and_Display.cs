using System;
using System.Collections.Generic;
using System.Linq;

public class Write_and_Display
{

    //Demonstration of a member variable
    int _someRandomjournal_question;

    public void writeRandomQuestions()
    {

       

        List<string> helpful_questions = new List<string>();

        helpful_questions.Add("Who was the most interesting person I interacted with today?");
        helpful_questions.Add("What was the best part of my day?");
        helpful_questions.Add("How did I see the hand of the Lord in my life today?");
        helpful_questions.Add("What was the strongest emotion I felt today?");
        helpful_questions.Add("If I had one thing I could do over today, what would it be?");
        helpful_questions.Add("What was the most daunting challenge that I faced today?");
        helpful_questions.Add("What was the moral in today's event");
        helpful_questions.Add("What were my set goals for today, as penned down early in the morning before setting out?");
        helpful_questions.Add("Which of my goals did I achieve today?");

        Random R = new Random();

        // get random number from 0 to 2.
        _someRandomjournal_question = R.Next(0, helpful_questions.Count());

        Console.WriteLine(" {0}", helpful_questions.ElementAt(_someRandomjournal_question));

        //return();


    }


    public void display_stored_question_and_answer()
    {

        string filename = "myjornal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

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