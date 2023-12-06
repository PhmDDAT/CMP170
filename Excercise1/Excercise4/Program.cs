using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Excercise4
{
    class WriteToFile
    {
        // Main Method
        static void Main(string[] args)
        {
            // This will create a file named tmp.txt
            // at the specified location
            StreamWriter sw = new StreamWriter("C://Windows Programming/tmp.txt");
            // To write on the console screen
            Console.WriteLine("Enter the Text that you want to write on File");
            // To read the input from the user
            string str = Console.ReadLine();
            // To write a line in buffer
            sw.WriteLine(str);
            // To write in output stream
            sw.Flush();
            // To close the stream
            sw.Close();
            Console.ReadKey();
        }
    }
}
