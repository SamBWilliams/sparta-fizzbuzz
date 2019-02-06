using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.loop();
            Console.Read();
        }

    }

    class Game
    {
        public static void loop()
        {
            for (int i = 1; i < 100; i++)
            {
                FizzBuzz fb = new FizzBuzz();
                FizzBuzz f = new Fizz();
                FizzBuzz b = new Buzz();

                if (i % 5 != 0 && i % 3 !=0 && i % 5 !=0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    fb.alert(i);
                    f.alert(i);
                    b.alert(i);
                }
                
            }
        }
    }

    class FizzBuzz
    {
        public virtual void alert(int num)
        {
            if (num % 15 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
        }
    }
    class Fizz : FizzBuzz
    {
        public override void alert(int num)
        {
            if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
        }
    }
    class Buzz : FizzBuzz
    {
        public override void alert(int num)
        {
            if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }
    }

}

