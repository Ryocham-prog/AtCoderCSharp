using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc182/tasks/abc182_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:数列Aに含まれる要素数の入力
                var n = int.Parse(Console.ReadLine());

                // 数列Aの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != n)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A1 A2 … An\")");
                    return;
                }

                var result = Enumerable.Range(2, inputArray.Max() - 1)
                    .Select(x => new { num = x, gcd = 0 })
                    .Aggregate(new { num = 0, gcd = 0 }, (maxGCD, next) =>
                    {
                        var gcdArray = inputArray.Where(x => x % next.num == 0);
                        if (maxGCD.gcd <= gcdArray.Count())
                        {
                            return new { num = next.num, gcd = gcdArray.Count() };
                        }
                        return maxGCD;
                    });

                Console.WriteLine(result.num.ToString());

                Console.Out.Flush();
            }
        }
    }
}
