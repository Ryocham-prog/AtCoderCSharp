using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc177/tasks/abc177_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // S,Tの入力
                var s = Console.ReadLine();
                var t = Console.ReadLine();

                var checkCount = s.Length - t.Length + 1;
                var minDiff = Enumerable.Range(1, checkCount)
                    .Select((x, index) => s.Substring(index, t.Length))
                    .Aggregate(9999, (min, next) =>
                    {
                        var diff = t.ToArray()
                        .Where((x, idx) => next.Substring(idx, 1) != t.Substring(idx, 1))
                        .Count();

                        return Math.Min(min, diff);
                    });

                Console.WriteLine(minDiff.ToString());

                Console.Out.Flush();
            }
        }
    }
}
