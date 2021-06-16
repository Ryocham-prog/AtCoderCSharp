using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc179/tasks/abc179_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:サイコロを振る数の入力
                var n = int.Parse(Console.ReadLine());

                // 二つのサイコロの目の入力
                var inputArray = Enumerable.Range(1, n)
                    .Select(x => Console.ReadLine().Split(' '))
                    .Select((input, index) => new { input, index });

                var sameIndexList = inputArray
                    .Where(x => x.input[0] == x.input[1])
                    .Select(x => x.index)
                    .ToArray();

                var beforeValue = 99;
                var result = sameIndexList.Aggregate(0, (count, next) =>
                {
                    var tmp = count;
                    if (tmp == 3)
                    {
                        return count;
                    }

                    count = beforeValue + 1 != next ? 1 : count + 1;
                    beforeValue = next;
                    return count;
                });

                var output = result == 3 ? "Yes" : "No";
                Console.WriteLine(output);

                Console.Out.Flush();
            }
        }
    }
}
