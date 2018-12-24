using System;

namespace HolyCS
{
    class Program
    {
        class ConvertTo
        {
            static public short Hinduism(string text)
            {
                return Convert.ToInt16(text);
            }
            static public int Judaism(string text)
            {
                return Convert.ToInt32(text);
            }
            static public long Christianity(string text)
            {
                return Convert.ToInt64(text);
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

