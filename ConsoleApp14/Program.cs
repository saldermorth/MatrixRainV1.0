using System;
using System.Threading;

namespace ConsoleApp14
{
    class Program
    {
       /* static ConsoleColor NormalColor = ConsoleColor.DarkGreen;
        static ConsoleColor GlowColor = ConsoleColor.Green;
        static ConsoleColor FancyColor = ConsoleColor.White;
        static String TextInput = "Matrix";*/
        //Follow the white rabbit


        static void Main(string[] args)
        {

            int Width = 111;
            int Height = 50;
            //for (int k = 0; k > 10; k++)
            for(; ;)

            {
                Random random2 = new Random();
                int i = random2.Next(0, 4);
                Thread.Sleep(5);
                if (i == 1)
                {
                    Console.Write(' ');
                    Random random = new Random();
                    Console.SetCursorPosition(random.Next(Width), random.Next(Height));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Random rnd = new Random();
                    char randomChar = (char)rnd.Next('a', 'z');
                    Console.WriteLine(randomChar);
                }
                else if (i == 2)
                {
                    Console.Write(' ');
                    Random random3 = new Random();
                    Console.SetCursorPosition(random3.Next(Width), random3.Next(Height));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Random rnd = new Random();
                    char randomChar = (char)rnd.Next('0', '9');
                    Console.WriteLine(randomChar);

                }
                else if (i == 3)
                {
                    Console.Write(' ');
                    Random random4 = new Random();
                    Console.SetCursorPosition(random4.Next(Width), random4.Next(Height));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Random rnd = new Random();
                    char randomChar = (char)rnd.Next('A', 'Z');
                    Console.WriteLine(randomChar);
                }
                else
                {
                    Console.Write(' ');
                    Random random5 = new Random();
                    Console.SetCursorPosition(random5.Next(Width), random5.Next(Height));
                    Console.ForegroundColor = ConsoleColor.Black;
                    Random rnd = new Random();
                    char randomChar = (char)rnd.Next('A', 'Z');
                    Console.WriteLine(randomChar);
                }

            }     

            
           /* for (int loopS = 0; loopS < 10000000; loopS ++)
            {
                Random random = new Random();
                Console.SetCursorPosition(random.Next(111), random.Next(50));
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Random rnd = new Random();
                char randomChar = (char)rnd.Next('a', '9');
                Console.WriteLine(randomChar);
            }*/
        }
    }
}
