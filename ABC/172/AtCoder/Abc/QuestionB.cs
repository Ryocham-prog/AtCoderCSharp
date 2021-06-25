using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc172/tasks/abc172_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列Sの入力
                var s = Console.ReadLine().ToArray();
                // 文字列Tの入力
                var t = Console.ReadLine().ToArray();

                var result = s.Where((x, index) => x != t[index]).Count();
                Console.WriteLine(result.ToString());

                Console.Out.Flush();

            }
        }
    }
}
