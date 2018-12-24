using System;

namespace HolyCS
{
    class Program
    {
        class ConvertTo
        {
            static public short Hinduism(int number)
            {
                return Convert.ToInt16(number);
            }
            static public int Judaism(int number)
            {
                return Convert.ToInt32(number);
            }
            static public long Christianity(int number)
            {
                return Convert.ToInt64(number);
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
            static public void SayLine(bool args)
            {
                Console.WriteLine(args);
            }
            static public void SayLine(char args)
            {
                Console.WriteLine(args);
            }
            static public string ListenPrayer()
            {
                return Console.ReadLine();
            }
            static public int Listen()
            {
                return Console.Read();
            }
        }

        static void Main(string[] args)
        {

        }
    }
}

