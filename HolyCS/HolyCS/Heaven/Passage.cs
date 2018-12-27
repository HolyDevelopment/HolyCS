namespace HolyCS.Heaven
{
    public class Passage
    {
        static string Text;

        public Passage(string s) => Text = s;
        public new string ToString() => Text;

        public static implicit operator Passage(string v) => new Passage(v);
        public static implicit operator string(Passage v) => Text;
    }
}
