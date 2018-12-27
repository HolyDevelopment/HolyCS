namespace HolyCS.Heaven
{
    public class Convert
    {
        static public short Hinduism(string text) => System.Convert.ToInt16(text);
        static public int Judaism(string text) => System.Convert.ToInt32(text);
        static public long Christianity(string text) => System.Convert.ToInt64(text);

        static public short Hinduism(Words text) => System.Convert.ToInt16(text);
        static public int Judaism(Words text) => System.Convert.ToInt32(text);
        static public long Christianity(Words text) => System.Convert.ToInt64(text);
    }
}
