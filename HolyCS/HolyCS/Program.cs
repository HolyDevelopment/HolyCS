using System;

namespace HolyCS
{

    class Program
    {
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
            static public string HearPrayer()
            {
                return(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
            string Adam;

            God.Sayeth("who is Adam");
            Adam = God.HearPrayer();
            God.Sayeth("You believe Adam is " + Adam + "?");
        }
    }
}
