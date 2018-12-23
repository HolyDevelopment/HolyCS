using System;

namespace HolyCS
{
    class Program
    {
        static public int ToChristianity()
        {
            return (Convert.ToInt32(Console.ReadLine()));
        }
        class God
        {
            static public void Say(string args)
            {
                Console.Write(args);
            }
            static public void Sayeth(string args)
            {
                Console.WriteLine(args + "eth");
            }
            static public void SayLine(string args)
            {
                Console.WriteLine(args);
            }
            static public void SayLine(int args)
            {
                Console.WriteLine(args);
            }
            static public string HearPrayer()
            {
                return (Console.ReadLine());
            }
            static public int Hear()
            {
                return (Console.Read());
            }
        }

        static void Main(string[] args)
        {
            God.SayLine("Hello my children");
            int g;
            g = Convert.ToInt32(God.HearPrayer());
            God.SayLine(g + 500);
        }
    }
}

