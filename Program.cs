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
            var list = new List<string>();
            var list2 = new List<string>();
            var list3 = new List<string>();

            var infilepath = new FileStream("infile_name.txt", FileMode.Open, FileAccess.Read);
            var outfilepath = new FileStream("outfile_name.txt", FileMode.Open, FileAccess.Read);
            var bytePosfilepath = new FileStream("byte_position.txt", FileMode.Open, FileAccess.Read);

            using (var streamReaderinfile = new StreamReader(infilepath, Encoding.UTF8))

            {
                string infilename;
                while ((infilename = streamReaderinfile.ReadLine()) != null)
                {

                    list.Add(infilename);


                    using (Stream InFile = new FileStream(infilename, FileMode.Open, FileAccess.Read))
                    {

                        using (var streamReaderByteposFile= new StreamReader(bytePosfilepath, Encoding.UTF8))
                        {
                            string bytePosfilename;
                            while ((bytePosfilename = streamReaderByteposFile.ReadLine()) != null)
                            { 

                                list.Add(bytePosfilename);


                                int bytenumber;

                                if (int.TryParse(bytePosfilename, out bytenumber))
                                {  
                                    
                                    InFile.Seek(bytenumber, SeekOrigin.Begin);

                                    Console.WriteLine("Removing header bytes....");


                                    using (var streamReaderOutfile = new StreamReader(outfilepath, Encoding.UTF8))
                                    {

                                       string outfilename;
                                        while ((outfilename = streamReaderOutfile.ReadLine()) != null)
                                        {

                                            list2.Add(outfilename);

                                            FileStream HeaderstrippedOutFile = new FileStream(outfilename, FileMode.CreateNew);

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

