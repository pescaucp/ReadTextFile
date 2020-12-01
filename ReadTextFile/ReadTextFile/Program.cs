using System;

namespace ReadTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // The files used in this example are created in the topic
            // How to: Write to a Text File. You can change the path and
            // file name to substitute text files of your own.

            // Example #1
            // Read the file as one string.
            //string text = System.IO.File.ReadAllText(@"D:\Drive\QI\CDLPortoAlegre.txt");

            // Display the file contents to the console. Variable text is a string.
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            //string[] lines;
            //lines = System.IO.File.ReadAllLines(@"D:\Drive\QI\CDLPortoAlegre.txt");

            // Display the file contents by using a foreach loop.
            // System.Console.WriteLine("Contents of WriteLines2.txt = ");
            //foreach (string line in lines)
            //{
            // Use a tab to indent each line of the file.
            //Console.WriteLine("\t" + line);

            //}

            // Keep the console window open in debug mode.
            string source;
            string destiny;

            if (args.Length == 2)
            {
                source = args[0];
                destiny = args[1];
            }

            else
            {
                source = @"D:\Drive\QI\CDLPortoAlegre.txt";
                destiny = @"D:\Drive\QI\CPF.TXT";
            }           

            ReadFromFile file = new ReadFromFile(source);

            CreateFile cpfList = new CreateFile(destiny,file.dataCPF());
            cpfList.Create();

            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
