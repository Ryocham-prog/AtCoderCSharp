using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc151/tasks/abc151_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:科目の数, K:テストの満点, M:目標平均点の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N K M\")");
                    return;
                }

                var n = inputArray[0];
                var k = inputArray[1];
                var m = inputArray[2];

                var scoreArray = Console.ReadLine().Split(' ')
                    .Select(i => int.Parse(i))
                    .ToArray();

                var diff = m * n - scoreArray.Sum();
                var result = (diff > k) ? -1
                    : (diff < 0) ? 0 : diff;
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
