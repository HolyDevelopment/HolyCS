namespace HolyCS.Heaven
{
    public class God
    {
        static public void Say(string args)
        {
            System.Console.Write(args);
        }
        static public void Sayeth(string args)
        {
            System.Console.WriteLine(args.Replace(" ", "eth ").Replace(".", "eth.").Replace("?", "eth?").Replace("!", "eth!"));
        }
        static public void SayLine(string args)
        {
            System.Console.WriteLine(args);
        }
        static public void SayLine(int args)
        {
            System.Console.WriteLine(args);
        }

        static public void Say(Words args)
        {
            System.Console.Write(args.ToString());
        }
        static public void Sayeth(Words args)
        {
            System.Console.WriteLine(args.ToString().Replace(" ", "eth ").Replace(".", "eth.").Replace("?", "eth?").Replace("!", "eth!") + "eth");
        }
        static public void SayLine(Words args)
        {
            System.Console.WriteLine(args.ToString());
        }

        static public void SayLine(bool args)
        {
            System.Console.WriteLine(args);
        }
        static public void SayLine(char args)
        {
            System.Console.WriteLine(args);
        }
        static public string ListenPrayer()
        {
            return System.Console.ReadLine();
        }
        static public int Listen()
        {
            return System.Console.Read();
        }
    }
}
