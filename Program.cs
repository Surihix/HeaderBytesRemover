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
            var list1 = new List<string>();
            var list2 = new List<string>();
            var list3 = new List<string>();


            // Open the infile_name.txt file in a streamreader and store it in a list
            using (var streamReaderinfile = new StreamReader("infile_name.txt", Encoding.UTF8))
            {
                string infilename;
                while ((infilename = streamReaderinfile.ReadLine()) != null)
                {
                    list1.Add(infilename);

                    // Open the file defined in the infile_name.txt file in a filestream
                    using (Stream InFile = new FileStream(infilename, FileMode.Open, FileAccess.Read))
                    {


                        // Open the byte_position.txt file in streamreader and store it in a list
                        using (var streamReaderByteposFile = new StreamReader("byte_position.txt", Encoding.UTF8))
                        {
                            string bytePosfilename;
                            while ((bytePosfilename = streamReaderByteposFile.ReadLine()) != null)
                            {
                                list2.Add(bytePosfilename);


                                // Convert the strings read in the byte_position.txt file to int
                                if (int.TryParse(bytePosfilename, out int bytenumber))
                                {
                                    // Seek to the byte specified in the byte_position.txt file 
                                    InFile.Seek(bytenumber, SeekOrigin.Begin);


                                    Console.WriteLine("Removing header bytes....");


                                    // Open the outfile_name.txt file in a streamreader and store it in a list.                                  
                                    using (var streamReaderOutfile = new StreamReader("outfile_name.txt", Encoding.UTF8))
                                    {
                                        string outfilename;
                                        while ((outfilename = streamReaderOutfile.ReadLine()) != null)
                                        {
                                            list3.Add(outfilename);


                                            // Create the file defined in the outfile_name.txt file in a filestream
                                            FileStream HeaderstrippedOutFile = new FileStream(outfilename, FileMode.CreateNew);

                                            // Copy the bytes to the output file filestream  
                                            _ = new MemoryStream();
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

