using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc190/tasks/abc190_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // A,B,Cの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B C\")");
                    return;
                }

                var a = inputArray[0];
                var b = inputArray[1];
                var c = inputArray[2];

                var result = string.Empty;
                // アメの数が同じなら、後手の勝ち
                if (a == b)
                {
                    result = c == 1 ? "Takahashi " : "Aoki";
                    Console.WriteLine(result);
                    return;
                }

                // アメの数が異なるなら、アメの数が多いほうの勝ち
                result = Math.Max(a, b) == a ? "Takahashi " : "Aoki";
                Console.WriteLine(result);
            }
        }
    }
}
