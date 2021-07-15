using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc156/tasks/abc156_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:コンテスト参加回数, R:表示レーティングの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N R\")");
                    return;
                }

                var n = inputArray[0];
                var r = inputArray[1];

                var result = n >= 10 ? r : r + (100 * (10 - n));

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
