using System;

namespace stopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Stopwatch Console App");
            Console.WriteLine("Commands:");
            Console.WriteLine("S: Start the stopwatch");
            Console.WriteLine("T: Stop the stopwatch");
            Console.WriteLine("R: Reset the stopwatch");
            Console.WriteLine("Q: Quit the application");

            char command = ' ';

            while (command != 'Q')
            {
                if (Console.KeyAvailable)
                {
                    command = Console.ReadKey(true).KeyChar;
                    switch (char.ToUpper(command))
                    {
                        case 'S':
                            stopwatch.Start();
                            break;
                        case 'T':
                            stopwatch.Stop();
                            break;
                        case 'R':
                            stopwatch.Reset();
                            break;
                        case 'Q':
                            Console.WriteLine("Exiting application...");
                            break;
                        default:
                            Console.WriteLine("Invalid command! Please use S, T, R, or Q.");
                            break;
                    }
                }

                stopwatch.Tick();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
