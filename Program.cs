using System;
using System.IO;

namespace HeaderBytesRemover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Check the number of arguements specified by the user 
            // and if its less than 3, then terminate the program
            if (args.Length != 3)
            {
               return;
            }

            // Storing the values specified in each of the arguements as variables
            string input_file_arg = args[0];
            long byte_pos = Convert.ToInt64(args[1]);
            string output_file_arg = args[2];


            // Open the input file specified in arg[0] in a filestream
            using (Stream InFile = new FileStream(input_file_arg, FileMode.Open, FileAccess.Read))
            {

               // Seek to the byte value specified in arg[1]
               InFile.Seek(byte_pos, SeekOrigin.Begin);

               // Create the output file specified in arg[2] in a filestream
               FileStream OutFile = new FileStream(output_file_arg, FileMode.CreateNew);

               Console.WriteLine("\nRemoving header bytes....");
                            
               // Copy the bytes to the output file filestream  
               _ = new MemoryStream();
               InFile.CopyTo(OutFile);
                                                             
            }

        }                        
        
    }
    
}    

