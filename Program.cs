using System;
using System.IO;

namespace HeaderBytesRemover
{
    internal class Program
    {
        static void Main(string[] args)
        {

                  Console.WriteLine("Enter your input filename with extension:");

                  // Open the file that the user has entered on the console in a filestream
                  using (Stream InFile = new FileStream(Console.ReadLine(), FileMode.Open, FileAccess.Read))
                     {

                        Console.WriteLine("\nInput the byte position: ");

                        if (int.TryParse(Console.ReadLine(), out int bytenumber))
                        {
                            // Seek to the byte specified in the byte_position.txt file 
                            InFile.Seek(bytenumber, SeekOrigin.Begin);

                            Console.WriteLine("\nEnter your output filename with extension: ");

                            // Create the file that the user has entered on the console in a filestream
                            FileStream HeaderstrippedOutFile = new FileStream(Console.ReadLine(), FileMode.CreateNew);

                            Console.WriteLine("\nRemoving header bytes....");
                            
                            // Copy the bytes to the output file filestream  
                            _ = new MemoryStream();
                            InFile.CopyTo(HeaderstrippedOutFile);
                                                             

                        }

                  }
        
                
        
        }
    
    }    

}

