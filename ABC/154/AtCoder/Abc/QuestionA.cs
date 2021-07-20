using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc154/tasks/abc154_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列S,Tの情報の入力
                var inputStrArray = Console.ReadLine().Split(' ').ToArray();
                if (inputStrArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"S T\")");
                    return;
                }

                var s = inputStrArray[0];
                var t = inputStrArray[1];

                // ボールの数A,Bの情報の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B\")");
                    return;
                }

                var a = inputArray[0];
                var b = inputArray[1];

                // 文字列Uの入力
                var u = Console.ReadLine();

                var resultA = s.Contains(u) ? a - 1 : a;
                var resultB = t.Contains(u) ? b - 1 : b;

                Console.WriteLine($"{resultA} {resultB}");

                Console.Out.Flush();
            }
        }
    }
}
