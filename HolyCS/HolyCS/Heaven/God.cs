namespace HolyCS.Heaven
{
    public class God
    {
        static public void Say(Passage args) => System.Console.Write(args);
        static public void Sayeth(string args) => System.Console.WriteLine(args.Replace(" ", "eth ").Replace(".", "eth.").Replace("?", "eth?").Replace("!", "eth!"));
        static public void SayLine(Passage args) => System.Console.WriteLine(args);
        
        static public void SayLine(Commandment args) => System.Console.WriteLine(args);
        static public void SayLine(bool args) => System.Console.WriteLine(args);
        static public void SayLine(char args) => System.Console.WriteLine(args);

        static public string ListenPrayer() => System.Console.ReadLine();
        static public int Listen() => System.Console.Read();
    }
}
