using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc164/tasks/abc164_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // A, B, C, Dの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 4)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B C D\")");
                    return;
                }

                var a = inputArray[0];
                var b = inputArray[1];
                var c = inputArray[2];
                var d = inputArray[3];

                // 倒すまでのターン
                var turnT = ((c % b) == 0) ? (c / b) : ((c / b) + 1);
                var turnA = ((a % d) == 0) ? (a / d) : ((a / d) + 1);

                var result = turnT <= turnA ? "Yes" : "No";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
