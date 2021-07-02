using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc165/tasks/abc165_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // K:目標のもとになる数の入力
                var n = long.Parse(Console.ReadLine());

                // A,B:出せる距離の範囲(A以上B以下)の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B\")");
                    return;
                }

                var a = inputArray[0];
                var b = inputArray[1];

                var tmp = (a % n == 0) ? (a / n) : (a / n + 1);
                var result = tmp * n <= b ? "OK" : "NG";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
