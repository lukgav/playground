// See https://aka.ms/new-console-template for more information


//// Done: 
// Create Sorter
// Create generator
//// TODO: 
// Convert numbers to colors
// Create UI
//Split up features and characteristics into classes: generator Class, Sorter Class, UI Class, (Colormap class?)
namespace ColorSorter
{

    public class Model{
        // Requires Generator
        // Constructor
        private Random rand;
        public int rowLength;
        public int columnLength;
        int[,] ColourArray;

        public Model(int pRowLength, int pColumnLength)
        {
            rand = new Random(1000);
            rowLength = pRowLength;
            columnLength = pColumnLength;
            ColourArray = new int[rowLength, columnLength];
        }

        public void generate2DArray(){
            for (int i=0; i<this.rowLength; i++){
                for (int j=0; j<this.columnLength; j++){
                    this.ColourArray[i,j] = rand.Next(255);
                }
            }

            //Print out column
            for (int i=0; i<this.rowLength; i++){
                for (int j=0; j<this.columnLength; j++){
                    Console.Write("{0};",this.ColourArray[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");

            return this.ColourArray;
        }

    }

    // class View{


    //     static void Color(){
    //         public static System.Drawing.Color FromArgb (int argb);
    //     }
    // }

    class Controller
    {
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
            }
            return arr;
        }

        static void Main(string[] args)
        {
            //Put into Model
            int rowLength = 10;
            int columnLength = 10;
            int[,] ColourArray = new int[rowLength, columnLength];
            Model model = new Model(rowLength, columnLength);

            ColourArray = model.generate2DArray();

            // int[,] ColourArray = new int[rowLength, columnLength];

            // for (int i=0; i<rowLength; i++){
            //     for (int j=0; j<columnLength; j++){
            //         ColourArray[i,j] = rand.Next(255);
            //     }
            // }

            // //Print out column
            // for (int i=0; i<rowLength; i++){
            //     for (int j=0; j<columnLength; j++){
            //         Console.Write("{0};",ColourArray[i,j]);
            //     }
            //     Console.WriteLine();
            // }
            // Console.WriteLine("---------------------------");

            // int[,] sortedColourArray = new int[rowLength, columnLength];
            // for (int j=0; j<columnLength; j++){
            //     sortedColourArray = InsertionSort2d(ColourArray, j);
            // }
            // for (int i=0; i<rowLength; i++){
            //     for (int j=0; j<columnLength; j++){
            //         Console.Write("{0};",sortedColourArray[i,j]);
            //     }
            //     Console.WriteLine();
            // }

            //Create random color generator
                //Should be in 2d array
                // needs to be in UI
                //values between 0-255

        //Use Quicksort algorithm to sort through colorsorter

        }
    }
}