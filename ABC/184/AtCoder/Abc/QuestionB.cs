using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc184/tasks/abc184_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:クイズの問題数, X:持ち点の初期値の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N X\")");
                    return;
                }

                var n = inputArray[0];
                var x = inputArray[1];

                // クイズ結果
                var quizResult = Console.ReadLine().ToArray();
                var point = quizResult.Aggregate(x, (sum, next) => next == 'o' ? sum + 1 : sum == 0 ? 0 : sum - 1);
                Console.WriteLine(point.ToString());

                Console.Out.Flush();
            }
        }
    }
}
