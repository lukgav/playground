// See https://aka.ms/new-console-template for more information
namespace ColorSorter
{
    class Program
    {


        // static int[] InsertionSort(int[] arr)
        // {
        //     int n = arr.Length; 
        //     for (int i = 1; i < n; ++i) { 
        //         int key = arr[i]; 
        //         int j = i - 1; 
    
        //         // Move elements of arr[0..i-1], 
        //         // that are greater than key, 
        //         // to one position ahead of 
        //         // their current position 
        //         while (j >= 0 && arr[j] > key) { 
        //             arr[j + 1] = arr[j]; 
        //             j = j - 1; 
        //         } 
        //         arr[j + 1] = key; 
        //     }
        // }
        //Basic and bad sort algorithm but quick and easy to implement and fix for bugs...
        static int[,] InsertionSort2d(int[,] arr, int columnNumber)
        {
            int rowLength = arr.GetLength(0); 
            int columnLength = arr.GetLength(1); 

            for (int i = 1; i < rowLength; i++) { 
                // for (int j = 1; j < columnLength; j++) { 
                int key = arr[columnNumber, i]; 
                int l = i - 1;
    
                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (l >= 0 && arr[columnNumber, l] > key) { 
                    arr[columnNumber, l + 1] = arr[columnNumber, l]; 
                    l = l - 1; 
                } 
                arr[columnNumber, l + 1] = key; 
                // }
            }
            return arr;
        }

        static void Main(string[] args)
        {

            Random rand = new Random(1000);
            int rowLength = 10;
            int columnLength = 10;
            int[,] ColourArray = new int[rowLength, columnLength];

            for (int i=0; i<rowLength; i++){
                for (int j=0; j<columnLength; j++){
                    ColourArray[i,j] = rand.Next(255);
                }
            }

            //Print out column
            for (int i=0; i<rowLength; i++){
                for (int j=0; j<columnLength; j++){
                    Console.Write("{0};",ColourArray[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");

            int[,] sortedColourArray = new int[rowLength, columnLength];
            for (int j=0; j<columnLength; j++){
                sortedColourArray = InsertionSort2d(ColourArray, j);
            }
            for (int i=0; i<rowLength; i++){
                for (int j=0; j<columnLength; j++){
                    Console.Write("{0};",sortedColourArray[i,j]);
                }
                Console.WriteLine();
            }

            //Create random color generator
                //Should be in 2d array
                // needs to be in UI
                //values between 0-255

        //Use Quicksort algorithm to sort through colorsorter

        }
    }
}