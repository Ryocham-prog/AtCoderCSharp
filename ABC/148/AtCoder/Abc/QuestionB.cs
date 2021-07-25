using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc148/tasks/abc148_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:文字列の長さの入力
                var n = int.Parse(Console.ReadLine());

                // S,T;文字列の入力
                var inputStrArray = Console.ReadLine().Split(' ');
                if (inputStrArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"S T\")");
                    return;
                }

                var s = inputStrArray[0];
                var t = inputStrArray[1];

                var result = Enumerable.Range(0, n)
                    .Aggregate(new StringBuilder(), (output, next) =>
                    {
                        var tmpS = s.Substring(next, 1);
                        output.Append(tmpS);

                        var tmpT = t.Substring(next, 1);
                        output.Append(tmpT);

                        return output;
                    }).ToString();

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
