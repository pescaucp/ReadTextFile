using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ReadTextFile
{
    class CreateFile
    {
        private string[] Lines;
        private string Destiny;
        // WriteAllLines creates a file, writes a collection of strings to the file,
        // and then closes the file.  You do NOT need to call Flush() or Close().
        
        public CreateFile(string destiny,String[] lines)
        {
            Lines = lines;
            Destiny = destiny;
        }

        public void Create()
        {
            DeleteFile();
           //Console.WriteLine(Lines[0]);
            System.IO.File.WriteAllLines(Destiny, Lines);
        }

        private void DeleteFile()
        {
            if (System.IO.File.Exists(Destiny))
            {
                try
                {
                    System.IO.File.Delete(Destiny);
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }
    }
}
