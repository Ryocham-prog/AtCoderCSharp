using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc147/tasks/abc147_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列の入力
                var s = Console.ReadLine();

                var len = s.Length;
                var result = Enumerable.Range(0, len / 2)
                    .Aggregate(0, (count, next) =>
                    {
                        var headStr = s.Substring(next, 1);
                        var tailStr = s.Substring(len - 1 - next, 1);

                        return headStr != tailStr ? count + 1 : count;
                    });

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
