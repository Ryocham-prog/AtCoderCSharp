using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc143/tasks/abc143_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                var success = Int32.TryParse(Console.ReadLine(), out int n);
                if(!success)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"2 <= n <= 50\")");
                    return;
                }

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ')
                    .Select(i => {
                        var success1 = Int32.TryParse(i, out int tmpVal);
                        return new { success = success1, val = tmpVal };
                    }).ToArray();
                if(inputArray.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"0 <= d <= 100\")");
                    return;
                }

                var takoInfoList = inputArray.Select(x => x.val).ToArray();

                var selectionList = takoInfoList
                    .SelectMany((x, index) =>
                    {
                        return takoInfoList.Skip(index + 1).Select(y => new List<int> { x, y });
                    });

                var result =selectionList
                    .Select(val => val[0] * val[1])
                    .Sum();
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
