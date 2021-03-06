// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// library to read in csv file. 
//Two methods: Using IO library or Text FieldParser Library. 
// //First lets use IO library
// using System.IO;
// using Microsoft.VisualBasic.FileIO.TextFieldParser

//Question: What is an IDispoable Object???

//------------------------------------------------------------
//DONE: 
    //read in data into a 2d Array
    // transpose data the 2d array
    // Convert 2d Array in CSV
//TODO: 
    // Allow to scan all files in current directory. Must look for CSV files.  
    //  If no CSV then return a string that says this
    // Make this a clickable application
//------------------------------------------------------------

namespace TransposeData
{
    class Program
    {
        static void Main(string[] args)
        {
            // try 
            // {
            //     // Only get files that begin with the letter "c".
            //     string[] dirs = Directory.GetFiles(@"./", "*.csv");
            //     Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
            //     foreach (string dir in dirs)
            //     {
            //         Console.WriteLine(dir);
            //     }
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("The process failed: {0}", e.ToString());
            // }
            string[] dirs = Directory.GetFiles(@"./", "*.csv");
            Console.WriteLine("The number of files starting with c is {0}.", dirs.Length);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine("The process failed: {0}", dirs[0]);
            // directoryScanner
            // string csvDir = "/home/luke/code/playground/tecan_test_1/TransposeData_Input.csv";
            // string csvDir = "/home/luke/code/playground/tecan_test_1/TransposeData_Input.csv";

            for (int csvFileIteration=0; csvFileIteration<dirs.Length; csvFileIteration++)
            {
                // string csvDir = "./TransposeData_Input.csv";
                // EXCEPTION: Null
                int rowLength = System.IO.File.ReadAllLines(dirs[csvFileIteration]).Length;
                int columnLength = 0;
                int currentColumnNumInFile = 0;
                using(var reader = new StreamReader(@dirs[csvFileIteration]))
                {
                    while (!reader.EndOfStream)
                    {
                        // Count number of rows to get row-size of array
                        // Count number of columns to get column-size of array
                        var line = reader.ReadLine();
                        // EXCEPTION: Null
                        var values = line.Split(';');
                        columnLength = values.Length;
                    }
                }
                string [,] arr = new string[columnLength, rowLength];
                using(var reader = new StreamReader(@dirs[csvFileIteration]))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        // EXCEPTION: Null
                        var values = line.Split(';');
                        for(int i=0;i < columnLength-1; i++)
                        {
                            // foreach(int j=0;j<rowLength-1; j++)
                            // {
                            arr[i,currentColumnNumInFile] = values[i] + ";";
                            Console.Write("{0};", values[i]);
                        }
                        Console.WriteLine("");
                        currentColumnNumInFile += 1;
                    }
                }
                //Print results to check if transpose was successful:
                Console.WriteLine("Current Array: ");
                for(int i=0;i < columnLength-1; i++)
                {
                    for(int j=0;j < rowLength; j++)
                    {
                        Console.Write("{0}", arr[i,j]);
                    }
                    Console.WriteLine();
                }
                char[] charsToRemove = {'.','/'};
                foreach (char c in charsToRemove)
                {
                    dirs[csvFileIteration] = dirs[csvFileIteration].Replace(c.ToString(), String.Empty);
                }
                dirs[csvFileIteration] = dirs[csvFileIteration].Replace("csv", String.Empty);

                string newCSVPath = @"./Output/"+dirs[csvFileIteration] + "_transposed";

                //Create Output Folder:
                System.IO.Directory.CreateDirectory(@"./Output");
                // string newCSVPath = "/home/luke/code/playground/tecan_test_1/transposed_data.csv";

                // file.WriteLine("HELLOW"); 
                using (StreamWriter file = new StreamWriter(newCSVPath +".csv"))
                {
                    for (int i = 0; i < columnLength-1; i++)
                    {
                            // Console.WriteLine("HELLOW"); 
                            for (int j=0; j<rowLength;j++)
                            {  
                                // file.WriteLine("HELLOW"); 
                                file.Write(arr[i,j]);
                            }
                            //go to next line
                            file.WriteLine();
                    }
                }

                Console.WriteLine("Opened CSV File: ");
                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(newCSVPath +".csv"))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}