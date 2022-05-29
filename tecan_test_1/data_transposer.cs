// library to read in csv file. 
using Microsoft.VisualBasic.FileIO.TextFieldParser

namespace TransposeData{
    class Program{


        public void transposeArray{

            //Exceptions: 




            
        } 

        publix void ReadCSVFile(string fileDir){
                        
            // TextFieldParser parser = new TextFieldParser(@fileDir);
        using (TextFieldParser parser = new TextFieldParser(@"c:\temp\test.csv"))
            {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(";");
            while (!parser.EndOfData) 
                {
                //Processing row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields) 
                    {
                        //TODO: Process field
                    }
                }
            }

        }
        

        


        static void Main{
            //read in data into a 2d Array
            // transpose data thw 2d array
            // return value
        }

    }
}