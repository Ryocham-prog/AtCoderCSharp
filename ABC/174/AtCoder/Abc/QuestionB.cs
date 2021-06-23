using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc174/tasks/abc174_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:点の数, D:原点からの比較距離の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N D\")");
                    return;
                }
                var n = inputArray[0];
                var d = inputArray[1];

                var xyArrayCount = Enumerable.Range(1, n)
                    .Select(x => Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray())
                    .Where(input => Math.Sqrt(Math.Pow(input[0], 2) + Math.Pow(input[1], 2)) <= d)
                    .Count();

                Console.WriteLine(xyArrayCount.ToString());

                Console.Out.Flush();
            }
        }
    }
}
