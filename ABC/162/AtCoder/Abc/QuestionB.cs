using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc162/tasks/abc162_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:項目数の入力
                var n = int.Parse(Console.ReadLine());

                var targetArraySum = Enumerable.Range(1, n)
                    .Aggregate(0L,(sum, next) => {
                        if (next % 3 == 0 || next % 5 == 0) return sum;

                        return sum += next;
                    });

                Console.WriteLine(targetArraySum);

                Console.Out.Flush();
            }
        }
    }
}
