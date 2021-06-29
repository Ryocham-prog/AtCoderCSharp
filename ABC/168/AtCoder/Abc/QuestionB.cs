using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc168/tasks/abc168_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // K:最大文字数の入力
                var n = int.Parse(Console.ReadLine());

                // S:文字列の入力
                var s = Console.ReadLine();

                var result = s.Length > n ? (s.Substring(0, n) + "...") : s;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
