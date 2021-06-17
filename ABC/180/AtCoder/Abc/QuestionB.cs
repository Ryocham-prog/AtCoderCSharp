using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc180/tasks/abc180_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:次元の数の入力
                var n = int.Parse(Console.ReadLine());

                // 点の情報の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();
                if (inputArray.Length != n)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"x1 x2 … xn \")");
                    return;
                }

                Console.WriteLine(inputArray.Select(x => Math.Abs(x)).Sum());
                Console.WriteLine(Math.Sqrt(inputArray.Select(x => Math.Pow(Math.Abs(x), 2)).Sum()));
                Console.WriteLine(inputArray.Select(x => Math.Abs(x)).Max());

                Console.Out.Flush();
            }
        }
    }
}
