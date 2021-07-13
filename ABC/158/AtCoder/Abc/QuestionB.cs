using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc158/tasks/abc158_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:先頭から取得するボールの数
                // A:加える青いボールの数
                // B:加える赤いボールの数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
                if (inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N A B\")");
                    return;
                }

                var n = inputArray[0];
                var a = inputArray[1];
                var b = inputArray[2];

                // 取得するボールの数を操作
                var blueQuo = (n / (a + b)) * a ;

                var blueRem = (n % (a + b)) < a ? (n % (a + b)) : a ;


                Console.WriteLine(blueQuo + blueRem);

                Console.Out.Flush();
            }
        }
    }
}
