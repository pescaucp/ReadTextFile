using System;
using System.Collections.Generic;
using System.Text;

using System.Reflection.Metadata.Ecma335;
using System.Linq;

namespace ReadTextFile
{
    class ReadFromFile
    {
        private string[] Lines;
        private string Source;

        public ReadFromFile(String source)
        {
            Source = source;
            Lines = System.IO.File.ReadAllLines(Source);
        }

        public string[] dataCPF()
        {
            List<string> data = new List<string>();
            foreach (string line in Lines)
            {
                if (line.StartsWith("CPF: "))
                {
                    Console.WriteLine("\n" + line.Substring(4, 14));
                    data.Add(line.Substring(5, 14));
                }
            }
            data.Add(data.Count().ToString());

            return data.ToArray();

        }

    }
}
