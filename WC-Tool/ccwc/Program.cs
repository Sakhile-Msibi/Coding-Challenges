namespace ccwc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            string filepath = "";

            if (args[0] == "-c")
            {
                try
                {
                    filepath = $".\\{args[1]}";
                    Console.WriteLine($"{program.GetNumberOfBytesOfAFile(filepath)} {args[1]}");
                }
                catch { }

            }
            else if (args[0] == "-l")
            {
                try
                {
                    filepath = $".\\{args[1]}";
                    Console.WriteLine($"{program.GetNumberOfLinesOfAFile(filepath)} {args[1]}");
                }
                catch { }
            }
            else if (args[0] == "-w")
            {
                try
                {
                    filepath = $".\\{args[1]}";
                    Console.WriteLine($"{program.GetNumberOfWordsOfAFile(filepath)} {args[1]}");
                }
                catch { }
            }

            Console.ReadLine();
        }

        private long GetNumberOfBytesOfAFile(string filepath)
        {
            long total = 0;

            try
            {
                return new FileInfo(filepath).Length;
            }
            catch { }
            
            return total;
        }

        private int GetNumberOfLinesOfAFile( string filepath )
        {
            return File.ReadAllLines(filepath).Length;
        }

        private int GetNumberOfWordsOfAFile(string filepath)
        {

        }
    }
}