using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    public static class WriteToFile<T>
    {
        static string path = AppDomain.CurrentDomain.BaseDirectory + @"\" + "../../files/queryResult.txt";

        public static void WriteToTextFile(IEnumerable<T> list)
        {
            using(StreamWriter writer = new StreamWriter(path))
            {
                foreach(T item in list)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
