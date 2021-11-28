using System;

namespace contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "C sharp";
            string s2 = "l";
            string s3 = "s";

            Console
                .WriteLine("Se houver um elemento na sequência dada:{0} ",
                s1.Contains(s2));

            Console
                .WriteLine("Se houver um elemento na sequência dada:{0} ",
                s1.Contains(s3));

        }
    }
}
