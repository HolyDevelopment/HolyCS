using System;
using System.Collections.Generic;
using System.Text;

namespace HolyCS.Heaven
{
    public class Commandment
    {
        static int Num;

        public Commandment(int s) => Num = s;
        public new int ToInt() => Num;

        public static implicit operator Commandment(int v) => new Commandment(v);
        public static implicit operator int(Commandment v) => Num;
    }
}
