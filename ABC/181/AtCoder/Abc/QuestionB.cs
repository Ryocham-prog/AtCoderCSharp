using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc181/tasks/abc181_b
    class QuestionB
    {
        class NumRange
        {
            public long StartNum { get; }
            public long EndNum { get; }

            public NumRange(long startNum, long endNum)
            {
                StartNum = startNum;
                EndNum = endNum;
            }
        }

        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:操作の回数の入力
                var n = int.Parse(Console.ReadLine());

                var inputArray = Enumerable.Range(1, n)
                    .Select(x => Console.ReadLine())
                    .Select(x => new NumRange (long.Parse(x.Split(' ')[0]), long.Parse(x.Split(' ')[1])))
                    .ToArray();

                var result = inputArray
                    .Select(x => (x.EndNum * (x.EndNum + 1) / 2) - ((x.StartNum - 1) * x.StartNum / 2))
                    .Sum();
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
