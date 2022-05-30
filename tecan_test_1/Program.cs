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



                Console.WriteLine("Current Array: ");
                for(int i=0;i < columnLength-1; i++)
                {
                    for(int j=0;j < rowLength; j++)
                    {
                        // foreach(int j=0;j<rowLength-1; j++)
                        // {
                        // arr[i,currentColumnNumInFile] = values[i];
                        Console.Write("{0}", arr[i,j]);
                    }
                    Console.WriteLine();
                }
                // Console.WriteLine(rowLength);
                // Console.WriteLine(columnLength);
                
                



            }
            //read in data into a 2d Array
            // transpose data thw 2d array
            // return value
        }
    }
}