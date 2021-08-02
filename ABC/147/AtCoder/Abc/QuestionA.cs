using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc147/tasks/abc147_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => {
                    var success = Int32.TryParse(i, out int tmpVal);
                    return new { success, val = tmpVal };
                }).ToArray();

                if (inputArray.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= Ai <= 13  (i = 1, 2, 3)\")");
                    return;
                }

                var tmp = inputArray.Select(x => x.val).Sum() ;
                var result = tmp < 22 ? "win" : "bust";

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
