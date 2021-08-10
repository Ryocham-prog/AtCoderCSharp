using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc138/tasks/abc138_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                if(!Int32.TryParse(Console.ReadLine(), out int n))
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= n <= 100\")");
                    return;
                }

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ')
                    .Select(i => {
                        var success = decimal.TryParse(i, out decimal tmpVal);
                        return new { success, val = tmpVal };
                    }).ToArray();

                if (inputArray.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= Ai <= 1000\")");
                    return;
                }

                var sumReverse = inputArray.Select(x => x.val)
                    .Aggregate(0m, (sum, next) =>
                    {
                        return sum + (1 / next);
                    });

                var result = 1 / sumReverse;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
