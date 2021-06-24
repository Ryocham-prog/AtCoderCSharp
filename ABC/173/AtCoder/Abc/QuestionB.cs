using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc173/tasks/abc173_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:テストケースの数の入力
                var n = int.Parse(Console.ReadLine());

                // S:ジャッジ結果の入力
                var resultList = Enumerable.Range(1, n)
                    .Select(x => Console.ReadLine())
                    .GroupBy(x => x)
                    .Select(x => new { val = x.Key, count = x.Count() })
                    .ToDictionary(x => x.val, x => x.count);

                var acResult = resultList.ContainsKey("AC") ? resultList["AC"] : 0;
                Console.WriteLine("AC x " + acResult);

                var waResult = resultList.ContainsKey("WA") ? resultList["WA"] : 0;
                Console.WriteLine("WA x " + waResult);

                var tleResult = resultList.ContainsKey("TLE") ? resultList["TLE"] : 0;
                Console.WriteLine("TLE x " + tleResult);

                var reResult = resultList.ContainsKey("RE") ? resultList["RE"] : 0;
                Console.WriteLine("RE x " + reResult);

                Console.Out.Flush();
            }
        }
    }
}
