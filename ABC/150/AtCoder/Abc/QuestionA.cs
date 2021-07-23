using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc150/tasks/abc150_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // K:500円の枚数, X:判定の金額の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"K X\")");
                    return;
                }

                var k = inputArray[0];
                var x = inputArray[1];

                var result = 500 * k >= x ? "Yes" : "No";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
