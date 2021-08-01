using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc210/tasks/abc210_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                Int32.TryParse(Console.ReadLine(), out int n);

                // 文字列の入力
                var s = Console.ReadLine();

                var result = s.IndexOf('1') % 2 == 0 ? "Takahashi" : "Aoki";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
