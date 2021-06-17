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
                    .Select((x, index) =>
                    {
                        var input = Console.ReadLine().Split(' ');
                        return new { input, index };
                    })
                                        .Where(x => x.input[0] == x.input[1])
                                        .ToArray();

                var result = inputArray
                    .Aggregate(new { count = 0, beforeindex = 99 }, (sameSeqData, next) =>
                    {

                        var tmp = sameSeqData.count;
                        if (tmp == 3)
                        {
                            return sameSeqData;
                        }

                        tmp = ((sameSeqData.beforeindex + 1) != next.index) ? 1 : (tmp + 1);
                        return new { count = tmp, beforeindex = next.index };

                    });

                var output = result.count == 3 ? "Yes" : "No";
                Console.WriteLine(output);

                Console.Out.Flush();
            }
        }
    }
}
