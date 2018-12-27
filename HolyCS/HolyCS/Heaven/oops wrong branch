namespace HolyCS.Heaven
{
    public class Words
    {
        static string Text;

        public Words(string s) => Text = s;
        public new string ToString() => Text;

        public static implicit operator Words(string v) => new Passage(v);
        public static implicit operator string(Passage v) => Text;
    }
}
