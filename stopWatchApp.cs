using System;

namespace stopWatch
{
    public class Stopwatch
    {
        private TimeSpan TimeElapsed;
        private bool IsRunning;
        private DateTime StartTime;
        public Stopwatch()
        {
            TimeElapsed = TimeSpan.Zero;
            IsRunning = false;
        }

        public void Start()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                StartTime = DateTime.Now;
                Console.WriteLine("Stopwatch Started!");
            }
            else
            {
                Console.WriteLine("Stopwatch is already running.");
            }
        }

        public void Stop()
        {
            if (IsRunning)
            {
                IsRunning = false;
                TimeElapsed += DateTime.Now - StartTime;
                Console.WriteLine($"Stopwatch Stopped! Total time: {TimeElapsed.Hours:D2}:{TimeElapsed.Minutes:D2}:{TimeElapsed.Seconds:D2}");
            }
            else
            {
                Console.WriteLine("Stopwatch is already stopped.");
            }
        }

        public void Reset()
        {
            TimeElapsed = TimeSpan.Zero;
            IsRunning = false;
            Console.WriteLine("Stopwatch Reset!");
        }

        public void Tick()
        {
            if (IsRunning)
            {
                var elapsed = DateTime.Now - StartTime + TimeElapsed;
                Console.Write($"\rElapsed Time: {elapsed.Hours:D2}:{elapsed.Minutes:D2}:{elapsed.Seconds:D2}   ");
            }
        }
    }
}
