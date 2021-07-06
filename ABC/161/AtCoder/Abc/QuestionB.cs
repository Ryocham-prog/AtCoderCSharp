using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc161/tasks/abc161_a
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:商品の種類, M:選ぶ人気商品の数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N M\")");
                    return;
                }

                var n = inputArray[0];
                var m = inputArray[1];

                var voteInfoArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i))
                    .OrderByDescending(x => x)
                    .ToArray();

                var checkVal = (decimal)voteInfoArray.Sum() / (decimal)(4 * m);

                // Aggregate利用
                var result = voteInfoArray.Take(m)
                                    .Aggregate(true, (judge, next) =>{
                                        if (!judge) return judge;

                                        return next >= checkVal;
                                    });

                var output = result ? "Yes" : "No";

                // Aggregate利用しない

                /*                var result = voteInfoArray
                                    .Take(m)
                                    .OrderBy(x => x)
                                    .ElementAtOrDefault(0);

                                var output = result >= checkVal ? "Yes" : "No";
                */
                Console.WriteLine(output);

                Console.Out.Flush();
            }
        }
    }
}
