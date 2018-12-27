namespace HolyCS.Heaven
{
    public class God
    {
        static public void Say(string args) => System.Console.Write(args);
        static public void Sayeth(string args) => System.Console.WriteLine(args.Replace(" ", "eth ").Replace(".", "eth.").Replace("?", "eth?").Replace("!", "eth!"));
        static public void SayLine(string args) => System.Console.WriteLine(args);
        
        static public void SayLine(int args) => System.Console.WriteLine(args);
        static public void SayLine(bool args) => System.Console.WriteLine(args);
        static public void SayLine(char args) => System.Console.WriteLine(args);

        static public string ListenPrayer() => System.Console.ReadLine();
        static public int Listen() => System.Console.Read();
    }
}
