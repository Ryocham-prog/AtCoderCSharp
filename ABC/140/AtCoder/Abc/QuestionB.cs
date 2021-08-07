using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc140/tasks/abc140_b
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
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"2 <= n <= 20\")");
                    return;
                }

                // 整数配列Aの入力
                var inputArrayA = Console.ReadLine().Split(' ')
                    .Select(i =>
                    {
                        var success = Int32.TryParse(i, out int tmpVal);
                        return new { success, val = tmpVal };
                    }).ToArray();

                if (inputArrayA.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= Ai <= N\")");
                    return;
                }

                // 整数配列Bの入力
                var inputArrayB = Console.ReadLine().Split(' ')
                    .Select(i =>
                    {
                        var success2 = Int32.TryParse(i, out int tmpVal2);
                        return new { success = success2, val = tmpVal2 };
                    }).ToArray();

                if (inputArrayB.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= Bi <= 50\")");
                    return;
                }

                // 整数配列Cの入力
                var inputArrayC = Console.ReadLine().Split(' ')
                    .Select(i =>
                    {
                        var success3 = Int32.TryParse(i, out int tmpVal3);
                        return new { success = success3, val = tmpVal3 };
                    }).ToArray();

                if (inputArrayC.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= Ci <= 50\")");
                    return;
                }

                var foodOrder = inputArrayA
                    .Select(x => x.val)
                    .ToArray();

                var valueList = inputArrayB
                    .Select((x, index) => new { val = x.val, index = index + 1 })
                    .ToArray();

                var addValueList = inputArrayC
                    .Select((x, index) => new { val = x.val, index = index + 1 })
                    .ToArray();

                var result = foodOrder
                    .Aggregate(new { valSum = 0, pre = 0 }, (sum, next) =>
                    {
                        var tmp = valueList
                        .Where(x => x.index == next)
                        .ElementAtOrDefault(0).val;

                        if (next != 1 && sum.pre == next - 1)
                        {
                            tmp += addValueList
                            .Where(x => x.index == sum.pre)
                            .ElementAtOrDefault(0).val;
                        }

                        return new { valSum = sum.valSum + tmp, pre = next };
                    });

                Console.WriteLine(result.valSum);

                Console.Out.Flush();
            }
        }
    }
}
