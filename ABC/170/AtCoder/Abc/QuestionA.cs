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

                var expectArray = Enumerable.Range(1, 5).ToArray();
                var result = inputArray
                    .Select((x, index) => new { val = x, index })
                    .Aggregate(0, (output, next) => {
                        if (next.val != expectArray[next.index]) return output = expectArray[next.index];

                        return output;
                    });

                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
