using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace HeaderBytesRemover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create three lists to store the text files and the data in it as strings  
            var list = new List<string>();
            var list2 = new List<string>();
            var list3 = new List<string>();

            // Create three filestream for the text files 
            var infilepath = new FileStream("infile_name.txt", FileMode.Open, FileAccess.Read);
            var outfilepath = new FileStream("outfile_name.txt", FileMode.Open, FileAccess.Read);
            var bytePosfilepath = new FileStream("byte_position.txt", FileMode.Open, FileAccess.Read);

            // Section for opening the infile_name.txt file in a streamreader and store it in a list
            using (var streamReaderinfile = new StreamReader(infilepath, Encoding.UTF8))

            {
                string infilename;
                while ((infilename = streamReaderinfile.ReadLine()) != null)
                {

                    list.Add(infilename);


                    // Section for opening the file defined in the infile_name.txt file in a filestream
                    using (Stream InFile = new FileStream(infilename, FileMode.Open, FileAccess.Read))
                    {
                        
                        // Section for opening the byte_position.txt file in streamreader and store it in a list
                        using (var streamReaderByteposFile= new StreamReader(bytePosfilepath, Encoding.UTF8))
                        {
                            string bytePosfilename;
                            while ((bytePosfilename = streamReaderByteposFile.ReadLine()) != null)
                            { 

                                list.Add(bytePosfilename);

                                
                                // Converting the strings read in the byte_position.txt file to int
                                int bytenumber;

                                if (int.TryParse(bytePosfilename, out bytenumber))
                                {  
                                    
                                    // Seek to the byte specified in the byte_position.txt file 
                                    InFile.Seek(bytenumber, SeekOrigin.Begin);

                                    Console.WriteLine("Removing header bytes....");

                                    
                                    // Section for creating the output file that is defined in the outfile_name.txt file 
                                    // in a streamreader and store it in a list.
                                    using (var streamReaderOutfile = new StreamReader(outfilepath, Encoding.UTF8))
                                    {

                                       string outfilename;
                                        while ((outfilename = streamReaderOutfile.ReadLine()) != null)
                                        {

                                            list2.Add(outfilename);
                                            
                                            // Section for creating the file defined in the outfile_name.txt file in a filestream
                                            FileStream HeaderstrippedOutFile = new FileStream(outfilename, FileMode.CreateNew);

                                            // Section for copying the bytes to the output file filestream.  
                                            MemoryStream stream = new MemoryStream();

                                            InFile.CopyTo(HeaderstrippedOutFile);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

