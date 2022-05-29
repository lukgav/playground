// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// library to read in csv file. 
//Two methods: Using IO library or Text FieldParser Library. 
// //First lets use IO library
// using System.IO;
// using Microsoft.VisualBasic.FileIO.TextFieldParser

namespace TransposeData
{
    class Program
    {
        static void Main(string[] args)
        {
            // string csvDir = "/home/luke/code/playground/tecan_test_1/TransposeData_Input.csv";
            string csvDir = "/home/luke/code/playground/tecan_test_1/TransposeData_Input.csv";
            using(var reader = new StreamReader(@csvDir))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                    Console.WriteLine(values[0]);

                }
            }
            //read in data into a 2d Array
            // transpose data thw 2d array
            // return value
        }
    }
}