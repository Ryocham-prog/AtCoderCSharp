using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc213/tasks/abc213_a
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
                        var success = Int32.TryParse(i, out int tmpVal);
                        return new { success, val = tmpVal };
                    }).ToArray();

                if (inputArray.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"0 <= A,B <= 255\")");
                    return;
                }

                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B\")");
                    return;
                }

                var a = inputArray[0].val;
                var b = inputArray[1].val;

                var result = a^b;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
