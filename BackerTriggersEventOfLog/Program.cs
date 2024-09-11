// See https://aka.ms/new-console-template for more information


// Why?
// This design enables
// triggering an event of the log service
// after backing up files.


namespace BackerSystem
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Backing... up...");

            File file = new File { Title = "File: A Story" };
            Console.WriteLine(file.Title);

            var backer = new Backer();
            var logService = new LogService();

            backer.Backed += logService.OnBackedUp;

            backer.BackerRun();

        }
    }
}

