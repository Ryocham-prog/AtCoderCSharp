using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc179/tasks/abc179_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // S:単数形の文字列の入力
                var s = Console.ReadLine();
                var result = s.Substring(s.Length - 1, 1) == "s" ? s + "es" : s + "s";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
