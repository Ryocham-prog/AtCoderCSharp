using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc159/tasks/abc159_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列Sの入力
                var s = Console.ReadLine();

                var size = (s.Length - 1) / 2;
                var result = s.Substring(0, size) == s.Substring(size + 1, size) ? "Yes" : "No";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
