using System;

namespace HolyCS
{
    class Program
    {
        class ConvertTo
        {
            static public int Christianity()
            {
                return (Convert.ToInt32(Console.ReadLine()));
            }
        }
        class God
        {
            static public void Say(string args)
            {
                Console.Write(args);
            }
            static public void Sayeth(string args)
            {
                Console.WriteLine(args.Replace(" ", "eth "));
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
            int r, r2;

            r = ConvertTo.Christianity();
            r2 = ConvertTo.Christianity();

            God.SayLine(r + r2);
        }
    }
}

