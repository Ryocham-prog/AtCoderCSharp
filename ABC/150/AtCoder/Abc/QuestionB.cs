using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc150/tasks/abc150_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:文字列の長さの入力
                Int32.TryParse(Console.ReadLine(), out int n);

                // S:文字列の入力
                var s = Console.ReadLine();

                var replaceStr = s.Replace("ABC", "");
                var result = (s.Length - replaceStr.Length) / 3;
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
