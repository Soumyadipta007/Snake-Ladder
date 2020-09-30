using System;

namespace Snake_Ladder
{
    class Program
    {
        public const int FinalPosition = 100;
        const int NOPLAY = 1;
        const int LADDER = 2;
        const int SNAKE = 3;
        static void Main(string[] args)
        {
            int position = 0;
            Console.WriteLine("Position : " + position);
            const int FinalPosition = 100;
            const int NOPLAY = 1;
            const int LADDER = 2;
            const int SNAKE = 3;
            while (position != FinalPosition)
            {
                Random random = new Random();
                int dieNumber = random.Next(1, 7);
                Console.WriteLine("Number came from die: " + dieNumber);
                int options = random.Next(1, 4);
                if (position + dieNumber == FinalPosition)
                {
                    Console.WriteLine("New Position: " + FinalPosition);
                    break;
                }
                if (position + dieNumber > FinalPosition)
                {
                    options = NOPLAY;
                }
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

            if (pl1Position == FinalPosition)
            {
                Console.WriteLine("Player 1 won.");
            }
            else
            {
                Console.WriteLine("Player 2 won.");
            }
        }
        public static int play(int position,int playerNo)
        {
            Random random = new Random();
            int dieNumber = random.Next(1, 7);
            Console.WriteLine("Number from die of Player"+playerNo+" : " + dieNumber);
            int options = random.Next(1, 4);
            if (position + dieNumber == FinalPosition)
            {
                Console.WriteLine("Player " + playerNo + " new position: " + FinalPosition);
                return FinalPosition;
            }
            if (position + dieNumber > FinalPosition)
            {
                options = NOPLAY;
            }
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
            Console.WriteLine("Player " + playerNo + " new position: " + position);
            return position;
        }
    }
}
