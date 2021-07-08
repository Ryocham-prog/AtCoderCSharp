using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc159/tasks/abc159_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:偶数のボールの数, M:奇数のボールの数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N M\")");
                    return;
                }

                var n = inputArray[0];
                var m = inputArray[1];

                var nPairs = n < 2 ? 0 : n * (n - 1) / 2;
                var mPairs = m < 2 ? 0 : m * (m - 1) / 2;

                Console.WriteLine(nPairs + mPairs);

                Console.Out.Flush();
            }
        }
    }
}
