namespace HolyCS.Heaven
{
    public class Convert
    {
        static public short Hinduism(Commandment text)
        {
            return System.Convert.ToInt16(text);
        }
        static public int Judaism(string text)
        {
            return System.Convert.ToInt32(text);
        }
        static public long Christianity(string text)
        {
            return System.Convert.ToInt64(text);
        }
    }
}
