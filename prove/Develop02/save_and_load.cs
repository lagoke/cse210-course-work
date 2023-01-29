using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JournalApp
{
    class Save_and_Load
    {
        public void save_journal(string filename)
        {
            // Copy the contents of "myjournal.txt" to the specified file
            File.Copy("myjournal.txt", filename, true);
        }

        public void load_journal(string filename_passed)
        {
            // Read all lines from the specified file
            string[] lines = System.IO.File.ReadAllLines(filename_passed);

            // Print each line to the console
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
