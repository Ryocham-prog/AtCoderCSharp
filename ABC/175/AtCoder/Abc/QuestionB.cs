using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc175/tasks/abc175_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N: 棒の本数の入力
                var n = int.Parse(Console.ReadLine());

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != n)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"L1 L2 … Ln\")");
                    return;
                }

                if (n < 3)
                {
                    Console.WriteLine("0");
                    return;
                }

                var groupList = inputArray.GroupBy(x => x)
                    .Select(x => new { val = x.Key, count = x.Count() })
                    .OrderBy(x => x.val).ToArray();

                var totalCount = groupList.SelectMany((x, idx) =>
                groupList.Skip(idx + 1).SelectMany((y, idx2) =>
                groupList.Skip(idx + 1).Skip(idx2 + 1).Select(z => new { x, y, z })))
                    .Aggregate(0, (result, next) => {
                        var tmp = result;

                        var first = next.x.val;
                        var second = next.y.val;
                        var third = next.z.val;

                        if (first + second > third) tmp += next.x.count * next.y.count * next.z.count;
                        return tmp;
                    });

                Console.WriteLine(totalCount.ToString());
                Console.Out.Flush();
            }
        }
    }
}


