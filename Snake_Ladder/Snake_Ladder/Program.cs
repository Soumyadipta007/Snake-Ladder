using System;

namespace Snake_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            Console.WriteLine("Position: " + position);
            const int FinalPosition = 100;
            const int NOPLAY = 1;
            const int LADDER = 2;
            const int SNAKE = 3;
            while (position < FinalPosition)
            {
                Random random = new Random();
                int dieNumber = random.Next(1, 7);
                Console.WriteLine("Number came from die: " + dieNumber);
                if (position + dieNumber >= FinalPosition)
                {
                    int newPosition = position + dieNumber;
                    Console.WriteLine("New Position: " + newPosition);
                    break;
                }
                int options = random.Next(1, 4);
                switch (options)
                {
                    case NOPLAY:
                        Console.WriteLine("No Play");
                        break;
                    case LADDER:
                        Console.WriteLine("Ladder");
                        position += dieNumber;
                        break;
                    case SNAKE:
                        Console.WriteLine("Snake");
                        if (position - dieNumber > 0)
                            position -= dieNumber;
                        else
                            position = 0;
                        break;
                }
                Console.WriteLine("New Position: " + position);
            }
        }
    }
}
