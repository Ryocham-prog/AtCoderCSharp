using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc205/tasks/abc205_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:数列の長さの入力
                var n = int.Parse(Console.ReadLine());

                // 数列Nの入力
                var inputArray = Console.ReadLine().Split(' ')
                    .Select(i => int.Parse(i))
                    .OrderBy(x => x)
                    .ToArray();

                var result = inputArray.SequenceEqual(Enumerable.Range(1, n).ToArray()) ? "Yes" : "No";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
