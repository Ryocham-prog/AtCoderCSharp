using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc170/tasks/abc170_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                // Aggregateを使う
/*
                var result = inputArray
                    .Select((x, index) => new { val = x, index = index + 1 })
                    .Aggregate(0, (output, next) => {
                        if (next.val != next.index) return next.index;

                        return output;
                    });
*/

                // Whereを使う
                var result = inputArray
                    .Select((x, index) => new { val = x, index = index + 1 })
                    .Where(item => item.val != item.index);
                var output = result.ElementAtOrDefault(0).index;
                Console.WriteLine(output.ToString());

                Console.Out.Flush();
            }
        }
    }
}
