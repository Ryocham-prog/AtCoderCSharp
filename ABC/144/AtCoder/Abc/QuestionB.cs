using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc144/tasks/abc144_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数Nの入力
                Int32.TryParse(Console.ReadLine(), out int n);

                var result = Enumerable.Range(1, 9)
                    .Aggregate(false, (judge, next) =>
                    {
                        if (judge) return judge;

                        var result2 = Enumerable.Range(1, 9)
                        .Aggregate(false, (judge2, next2) =>
                        {
                            if (judge2) return judge2;

                            return next * next2 == n;
                        });

                        return result2;
                    });

                var output = result ? "Yes" : "No";
                Console.WriteLine(output);

                Console.Out.Flush();
            }
        }
    }
}
