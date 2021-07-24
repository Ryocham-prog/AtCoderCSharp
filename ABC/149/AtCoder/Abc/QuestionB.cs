using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc149/tasks/abc149_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // A,B:クッキーの枚数, K:繰り返す回数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
                if (inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B K\")");
                    return;
                }

                var a = inputArray[0];
                var b = inputArray[1];
                var k = inputArray[2];

                if (a > k)
                {

                    Console.WriteLine($"{a - k} {b}");
                    return;
                }

                b -= (k - a);
                if (b < 0) b = 0;

                Console.WriteLine($"0 {b}");

                Console.Out.Flush();
            }
        }
    }
}
