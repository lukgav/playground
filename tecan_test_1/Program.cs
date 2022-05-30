// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// library to read in csv file. 
//Two methods: Using IO library or Text FieldParser Library. 
// //First lets use IO library
// using System.IO;
// using Microsoft.VisualBasic.FileIO.TextFieldParser

//Question: What is an IDispoable Object???



namespace TransposeData
{
    class Program
    {
        static void Main(string[] args)
        {
            // string csvDir = "/home/luke/code/playground/tecan_test_1/TransposeData_Input.csv";
            string csvDir = "/home/luke/code/playground/tecan_test_1/TransposeData_Input.csv";
            // EXCEPTION: Null
            int rowLength = System.IO.File.ReadAllLines(csvDir).Length;
            int columnLength = 0;
            int currentColumnNumInFile = 0;
            using(var reader = new StreamReader(@csvDir))
            {

                // List<string> listA = new List<string>();
                // List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    // rowLength += 1;

                    // Count number of rows to get row-size of array
                    // Count number of columns to get column-size of array
                    var line = reader.ReadLine();
                    // EXCEPTION: Null
                    var values = line.Split(';');
                    columnLength = values.Length;
                }
            }
            string [,] arr = new string[columnLength, rowLength];
            using(var reader = new StreamReader(@csvDir))
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
            // string newCSVPath = @"./transposed_data.csv";
            string newCSVPath = "/home/luke/code/playground/tecan_test_1/transposed_data.csv";

            // file.WriteLine("HELLOW"); 
            using (StreamWriter file = new StreamWriter(newCSVPath))
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
            using (StreamReader sr = File.OpenText(newCSVPath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }


        // using (FileStream fs = File.Create(newCSV))
        // {   
        //     for(int i=0;i < columnLength-1; i++)
        //     {
        //         for(int j=0;j < rowLength; j++)
        //         {
        //             fs.Write(arr[i,j]);
        //         }
        //     }
        //     // byte[] info = new UTF8Encoding(true).GetBytes(arr);
        //     // string[,] info = arr;
        //     // // Add some information to the file.
        //     // fs.Write(info, 0, info.Length);
        // }

        // using (System.IO.StreamWriter file = new System.IO.StreamWriter(newCSV))
        // {
        //     foreach (Object obj in arr)
        //     {
        //         file.Write(obj.ToString());
        //     }
        // }

        // using (System.IO.StreamWriter file = new System.IO.StreamWriter(csvDir))
        // {
        //     file.Write(string.Join("", arr));
        // }

            //read in data into a 2d Array
            // transpose data the 2d array
            // Convert 2d Array in CSV
            // Allow to scan all files in current directory. Must look for CSV files.  
            //  If no CSV then return a string that says this
            // Make this a clickable application
        // }
    }
}