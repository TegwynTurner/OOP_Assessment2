using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_Assessment2
{
    class Select_File
    {
        static string firstFileLoad;
        static string secondFileLoad;


        // First file selection
        public static void Select_FirstFile()
        {
            // Starting the console colour as white
            Console.ForegroundColor = ConsoleColor.White;


            // Getting the first file choice from the user 
            Console.Write("Please select the first file from one of the following files: \n" + 
               "(1) File 1a \n" +
               "(2) File 1b \n" +
               "(3) File 2a \n" +
               "(4) File 2b \n" +
               "(5) File 3a \n" +
               "(6) File 3b \n > ");

            string firstFileChoice = Console.ReadLine();

            // Reloading the class if the user selects an invalid option
            if ((firstFileChoice != "1") && (firstFileChoice != "2") && (firstFileChoice != "3") && (firstFileChoice != "4") && (firstFileChoice != "5") && (firstFileChoice != "6"))
            {
                Console.Clear();
                Select_FirstFile();
            }

            // Passing file choice to Load_File
            switch (firstFileChoice)
            {
                case "1":
                    firstFileChoice = "1a";
                    firstFileLoad = Load_File(firstFileChoice);
                    break;

                case "2":
                    firstFileChoice = "1b";
                    firstFileLoad = Load_File(firstFileChoice);
                    break;

                case "3":
                    firstFileChoice = "2a";
                    firstFileLoad = Load_File(firstFileChoice);
                    break;

                case "4":
                    firstFileChoice = "2b";
                    firstFileLoad = Load_File(firstFileChoice);
                    break;

                case "5":
                    firstFileChoice = "3a";
                    firstFileLoad = Load_File(firstFileChoice);
                    break;

                case "6":
                    firstFileChoice = "3b";
                    firstFileLoad = Load_File(firstFileChoice);
                    break;
            }

            // Passing the file name onto the second file selection
            // This will make it easier for the comparison class to be called later on
            Select_SecondFile(firstFileLoad);
        }


        // Second file selection
        public static void Select_SecondFile(string firstFile)
        {
            // Getting the first file choice from the user 
            Console.Write("Please select the second file from one of the following files: \n" +
               "(1) File 1a \n" +
               "(2) File 1b \n" +
               "(3) File 2a \n" +
               "(4) File 2b \n" +
               "(5) File 3a \n" +
               "(6) File 3b \n > ");

            string secondFileChoice = Console.ReadLine();

            // Reloading the class if the user selects an invalid option
            if ((secondFileChoice != "1") && (secondFileChoice != "2") && (secondFileChoice != "3") && (secondFileChoice != "4") && (secondFileChoice != "5") && (secondFileChoice != "6"))
            {
                Console.Clear();
                Select_SecondFile(firstFile);
            }

            // Passing file choice to Load_File
            switch (secondFileChoice)
            {
                case "1":
                    secondFileChoice = "1a";
                    secondFileLoad = Load_File(secondFileChoice);
                    break;

                case "2":
                    secondFileChoice = "1b";
                    secondFileLoad = Load_File(secondFileChoice);
                    break;

                case "3":
                    secondFileChoice = "2a";
                    secondFileLoad = Load_File(secondFileChoice);
                    break;

                case "4":
                    secondFileChoice = "2b";
                    secondFileLoad = Load_File(secondFileChoice);
                    break;

                case "5":
                    secondFileChoice = "3a";
                    secondFileLoad = Load_File(secondFileChoice);
                    break;

                case "6":
                    secondFileChoice = "3b";
                    secondFileLoad = Load_File(secondFileChoice);
                    break;
            }

            // Passing the files over for comparison
            Compare_Files.fileComparison(firstFile, secondFileLoad);
        }

        
        // Loading in files ready for comparison
        private static string Load_File(string fileSelection)
        {
            // Create the file name
            string fileName = "Git_Files\\GitRepositories_" + fileSelection + ".txt";

            // Retrieve the file
            try
            {
                StreamReader file = new StreamReader(fileName);
                string loadedFile = file.ReadToEnd().Trim();

                file.Close();
                Console.Clear();

                return loadedFile;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Could not find {fileName}: {exception.Message}");
                throw;
            }
        }
    }
}
