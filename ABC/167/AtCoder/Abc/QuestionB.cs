using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc167/tasks/abc167_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // A:1のカード枚数, B:0のカード枚数, C:-1のカード枚数, K:取るカード枚数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 4)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B C K\")");
                    return;
                }

                var k = inputArray[3];

                var result = inputArray
                    .Take(3)
                    .Select((x, index) => new { val = x, index })
                    .Aggregate(new { sum = 0, count = k }, (sum, next) =>
                    {
                        if (sum.count == 0) return sum;

                        var tmpVal = sum.sum;
                        var calcCnt = Math.Min(next.val, sum.count);
                        switch (next.index)
                        {
                            case 0:
                                tmpVal += 1 * calcCnt;
                                break;

                            case 1:
                                tmpVal += 0 * calcCnt;
                                break;

                            case 2:
                                tmpVal += -1 * calcCnt;
                                break;

                            default:
                                break;
                        }

                        return new { sum = tmpVal, count = sum.count - calcCnt };
                    })
                    .sum;

                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
