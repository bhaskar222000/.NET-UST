using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOdemo
{
     class WriterAndReader
    {
        static string file = @"/test.txt";
        static void Main(string[] args)
        {
            Write();
            Read();
        }

         static void Write()
        {
            StreamWriter filestream= new StreamWriter(file);
            filestream.WriteLine("hi, how are you");
            filestream.WriteLine("i am fine");
            filestream.Close();
            
        }

         static void Read()
        {
            StreamReader reader= new StreamReader(file);
            string s = null;
            while((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            reader.Close();
            
        }
    }
}
