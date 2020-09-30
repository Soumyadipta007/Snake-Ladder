using System;

namespace Snake_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            Console.WriteLine("Position: "+position);
            Random random = new Random();
            int dieNumber = random.Next(1, 7);
            Console.WriteLine("Number came from die: " + dieNumber);
        }
    }
}
