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
        private int rowLength;
        private int columnLength;
        private int[,] colourArray;

        public Model(int pRowLength, int pColumnLength)
        {
            rand = new Random(1000);
            rowLength = pRowLength;
            columnLength = pColumnLength;
            colourArray = new int[rowLength, columnLength];
        }

        public int[,] generate2DArray(){
            for (int i=0; i<this.rowLength; i++){
                for (int j=0; j<this.columnLength; j++){
                    this.colourArray[i,j] = rand.Next(255);
                }
            }

            //Print out column
            for (int i=0; i<this.rowLength; i++){
                for (int j=0; j<this.columnLength; j++){
                    Console.Write("{0};",this.colourArray[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");

            return this.ColourArray;
        }


        // Properties: 
        public Model GetModel()
        {
            return this;
        }


        public int[,] ColourArray
        {
            get => colourArray;
            set => colourArray = value;
        }

        public int RowLength
        {
            get => rowLength;
        }

        public int ColumnLength
        {
            get => columnLength;
        }
    }


    

    // class View{


    //     static void Color(){
    //         public static System.Drawing.Color FromArgb (int argb);
    //     }
    // }

    class Controller
    {
        Model model;
        public Controller(Model pModel)
        {
            model = pModel;
        }


        public int[,] InsertionSort2d(int columnNumber)
        {
            int[,] arr = model.ColourArray;
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

        public int[,] sortArray(){
            int[,] sortedColourArray = new int[model.RowLength, model.ColumnLength];

            for (int j=0; j<model.ColumnLength; j++){
                sortedColourArray = this.InsertionSort2d(j);
            }

            return sortedColourArray;
        }

        // static void Main(string[] args)
        // {
        //     //Put into Model
        //     int rowLength = 10;
        //     int columnLength = 10;
        //     int[,] ColourArray = new int[rowLength, columnLength];
        //     Model model = new Model(rowLength, columnLength);

        //     ColourArray = model.generate2DArray();

        //     // int[,] ColourArray = new int[rowLength, columnLength];

        //     // for (int i=0; i<rowLength; i++){
        //     //     for (int j=0; j<columnLength; j++){
        //     //         ColourArray[i,j] = rand.Next(255);
        //     //     }
        //     // }

        //     // //Print out column
        //     // for (int i=0; i<rowLength; i++){
        //     //     for (int j=0; j<columnLength; j++){
        //     //         Console.Write("{0};",ColourArray[i,j]);
        //     //     }
        //     //     Console.WriteLine();
        //     // }
        //     // Console.WriteLine("---------------------------");
            
        //     int[,] sortedColourArray = new int[model.rowLength, model.columnLength];
        //     for (int j=0; j<model.columnLength; j++){
        //         sortedColourArray = InsertionSort2d(model.ColourArray, j);
        //     }
        //     for (int i=0; i<model.rowLength; i++){
        //         for (int j=0; j<model.columnLength; j++){
        //             Console.Write("{0};",sortedColourArray[i,j]);
        //         }
        //         Console.WriteLine();
        //     }

            //Create random color generator
                //Should be in 2d array
                // needs to be in UI
                //values between 0-255

        //Use Quicksort algorithm to sort through colorsorter

        }

    class Program
    {
        static void Main(string[] args)
        {
            //Put into Model
            int rowLength = 10;
            int columnLength = 10;
            int[,] ColourArray = new int[rowLength, columnLength];
            Model model = new Model(rowLength, columnLength);
            
            model.generate2DArray();
            Controller controller = new Controller(model);


            // controller.InsertionSort2d();

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

            int [,] sortedColourArray = controller.sortArray();
            for (int i=0; i<rowLength; i++){
                for (int j=0; j<columnLength; j++){
                    Console.Write("{0};",sortedColourArray[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}