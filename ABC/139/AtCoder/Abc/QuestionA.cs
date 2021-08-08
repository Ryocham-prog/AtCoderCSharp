using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc139/tasks/abc139_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列の入力
                var s = Console.ReadLine();
                var t = Console.ReadLine();

                var result = Enumerable.Range(0, 3)
                    .Aggregate(0, (match, next) => {
                        return s.Substring(next, 1) == t.Substring(next, 1) ? match + 1 : match;
                    });

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
