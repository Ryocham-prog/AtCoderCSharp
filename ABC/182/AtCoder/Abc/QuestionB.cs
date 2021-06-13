using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc182/tasks/abc182_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:数列Aに含まれる要素数の入力
                var n = int.Parse(Console.ReadLine());

                // 数列Aの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != n)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A1 A2 … An\")");
                    return;
                }

                var numArray = Enumerable.Range(2, inputArray.Max() - 1).ToArray();
                var gcdMax = 0;
                var result = 0;
                foreach (var num in numArray)
                {
                    var gcdArray = inputArray.Where(x => x % num == 0);
                    if (gcdMax <= gcdArray.Count())
                    {
                        gcdMax = gcdArray.Count();
                        result = num;
                    }
                }
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
