using System;

namespace ConsoleApp14
{
    class Program
    {
       /* static ConsoleColor NormalColor = ConsoleColor.DarkGreen;
        static ConsoleColor GlowColor = ConsoleColor.Green;
        static ConsoleColor FancyColor = ConsoleColor.White;
        static String TextInput = "Matrix";*/


        static void Main(string[] args)
        {
            

            //for (int k = 0; k > 10; k++)
            for(; ;)

            {
                Random random2 = new Random();
                int i = random2.Next(0, 4);
               
                if (i == 1)
                {
                    Console.Write(' ');
                    Random random = new Random();
                    Console.SetCursorPosition(random.Next(111), random.Next(50));
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Random rnd = new Random();
                    char randomChar = (char)rnd.Next('a', 'z');
                    Console.WriteLine(randomChar);
                }
                else if (i == 2)
                {
                    Console.Write(' ');
                    Random random3 = new Random();
                    Console.SetCursorPosition(random3.Next(111), random3.Next(50));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Random rnd = new Random();
                    char randomChar = (char)rnd.Next('0', '9');
                    Console.WriteLine(randomChar);

                }
                else if (i == 3)
                {
                    Console.Write(' ');
                    Random random4 = new Random();
                    Console.SetCursorPosition(random4.Next(111), random4.Next(50));
                    Console.ForegroundColor = ConsoleColor.White;
                    Random rnd = new Random();
                    char randomChar = (char)rnd.Next('A', 'Z');
                    Console.WriteLine(randomChar);
                }
                else
                {
                    Console.Write(' ');
                    Random random5 = new Random();
                    Console.SetCursorPosition(random5.Next(111), random5.Next(50));
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
