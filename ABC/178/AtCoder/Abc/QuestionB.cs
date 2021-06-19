using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc178/tasks/abc178_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数a,b,c,dの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
                if (inputArray.Length != 4)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"a b c d\")");
                    return;
                }

                var result = inputArray
                    .Select((val, index) => new { val, index })
                    .Aggregate(long.MinValue, (max, next) => {
                        if (next.index > 1) return max;

                        var maxXY = Math.Max(next.val * inputArray[2], next.val * inputArray[3]);

                        return Math.Max(max, maxXY);
                    });

                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
