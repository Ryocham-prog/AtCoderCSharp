using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc211/tasks/abc211_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ')
                    .Select(i => {
                        var success = Decimal.TryParse(i, out Decimal tmpVal);
                        return new { success, val = tmpVal };
                    }).ToArray();

                if (inputArray.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"50 < B <= A <= 300\")");
                    return;
                }

                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B\")");
                    return;
                }

                var a = inputArray[0].val;
                var b = inputArray[1].val;

                Console.WriteLine((a + 2 * b) / 3);

                Console.Out.Flush();
            }
        }
    }
}
