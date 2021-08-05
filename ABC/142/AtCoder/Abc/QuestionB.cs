using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc142/tasks/abc142_b
    class QuestionB
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

                if(inputArray.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= N <= 100000, 1 <= K <= 500\")");
                    return;
                }

                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N K\")");
                    return;
                }
                var n = inputArray[0].val;
                var k = inputArray[1].val;

                var inputList2 = Console.ReadLine().Split(' ')
                    .Select(i => {
                        var success = Int32.TryParse(i, out int tmpVal2);
                        return new { success, val = tmpVal2 };
                    }).ToArray();

                if (inputList2.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= h <= 500\")");
                    return;
                }

                var heightList = inputList2
                    .Select(x => x.val)
                    .ToArray();

                var result = heightList
                    .Where(x => x >= k)
                    .Count();

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
