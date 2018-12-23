using System;

namespace HolyCS
{
    class Program
    {
        class ConvertTo
        {
            static public short Hinduism()
            {
                return (Convert.ToInt16(Console.ReadLine()));
            }
            static public int Judaism()
            {
                return (Convert.ToInt32(Console.ReadLine()));
            }
            static public long Christianity()
            {
                return (Convert.ToInt64(Console.ReadLine()));
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

            r = ConvertTo.Judaism();
            r2 = ConvertTo.Judaism();

            God.SayLine(r + r2);
        }
    }
}

