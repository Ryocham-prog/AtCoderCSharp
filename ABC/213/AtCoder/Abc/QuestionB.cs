using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc213/tasks/abc213_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                if (!Int32.TryParse(Console.ReadLine(), out int n))
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"2 <= n <= 2 * 100000\")");
                    return;
                }

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ')
                    .Select(i => {
                        var success = Int32.TryParse(i, out int tmpVal);
                        return new { success, val = tmpVal };
                    }).ToArray();

                if (inputArray.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= Ai <= 1000000000\")");
                    return;
                }

                var infoList = inputArray
                    .Select((x, index) => new { val = x.val, index = index + 1 })
                    .OrderByDescending(x => x.val)
                    .ToArray();

                var result = infoList.ElementAtOrDefault(1).index;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
