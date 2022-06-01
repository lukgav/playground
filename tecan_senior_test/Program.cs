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


    

    public class View{
        
        public View()
        {

        }

        public void Print2dArray(int[,] pArr, int pRowLength, int pColumnLength){
            for (int i=0; i<pRowLength; i++){
                for (int j=0; j<pColumnLength; j++){
                    Console.Write("{0};",pArr[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
        }

        // static void Color(){
        //     public static System.Drawing.Color FromArgb (int argb);
        // }
    }

    class Controller
    {
        Model model;
        View view;
        public Controller(Model pModel, View pView)
        {
            model = pModel;
            view = pView;
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

        //OLD TODOS
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
            View view = new View();

            model.generate2DArray();
            view.Print2dArray(model.ColourArray, model.RowLength, model.ColumnLength);
                        //Print out column

            Controller controller = new Controller(model,view);

            controller.sortArray();

            view.Print2dArray(model.ColourArray, model.RowLength, model.ColumnLength);

            // for (int i=0; i<rowLength; i++){
            //     for (int j=0; j<columnLength; j++){
            //         Console.Write("{0};",sortedColourArray[i,j]);
            //     }
            //     Console.WriteLine();
            // }
        }
    }
}