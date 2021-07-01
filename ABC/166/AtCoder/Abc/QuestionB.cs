using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc166/tasks/abc166_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:すぬけ君の数, K:お菓子の種類の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N K\")");
                    return;
                }

                var n = inputArray[0];
                var k = inputArray[1];

                var snackInfo = Enumerable.Range(1, k)
                    .Select((x, index) =>
                    {
                        // d: dnのお菓子を持っている人数
                        var d = int.Parse(Console.ReadLine());

                        // A:お菓子を持っている人
                        var aStr= Console.ReadLine();
                        var a = (d == 1) ? new int[1] { int.Parse(aStr) } : aStr.Split(' ').Select(i => int.Parse(i));

                        return new { d, a };
                    }).ToArray();

                var trickCount = Enumerable.Range(1, n)
                    .Select(check => {
                        var treatCount = snackInfo.Where(x => x.a.Contains(check)).Count();

                        return treatCount;
                    })
                    .Where(x => x == 0)
                    .Count();

                Console.WriteLine(trickCount.ToString());

                Console.Out.Flush();
            }
        }
    }
}
