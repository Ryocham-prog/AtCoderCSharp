using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
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

                if (inputArray.Where(a => !(a.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= K <= 100, 0 <= X <= 100\")");
                    return;
                }

                var k = inputArray[0].val;
                var x = inputArray[1].val;

                var negaVal = x - (k - 1) < -1000000 ? -1000000 : x - (k - 1);
                var posiVal = x + (k - 1) > 1000000 ? 1000000 : x + (k - 1);

                var result = String.Join(" ", Enumerable.Range(negaVal, posiVal - negaVal + 1));
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
