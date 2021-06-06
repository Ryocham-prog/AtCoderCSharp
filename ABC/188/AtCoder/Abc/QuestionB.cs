using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc188/tasks/abc188_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {

                Console.SetOut(sw);

                // N:次元の入力
                var n = int.Parse(Console.ReadLine());

                // ベクトルAの入力
                var inputArrayA = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArrayA.Length != n)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A1 A2 A3 … An\")");
                    return;
                }

                // ベクトルBの入力
                var inputArrayB = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArrayB.Length != n)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"B1 B2 B3 … Bn\")");
                    return;
                }

                var sumAB = Enumerable.Range(0, n)
                    .Select(x => inputArrayA[x] * inputArrayB[x])
                    .Sum();

                var result = sumAB == 0 ? "Yes" : "No";

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
