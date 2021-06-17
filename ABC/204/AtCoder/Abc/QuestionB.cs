using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc204/tasks/abc204_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // n:木の本数の入力
                var n = int.Parse(Console.ReadLine());

                // An：木に成っている木の実の数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != n)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A1 A2 … An\")");
                    return;
                }

                var result = inputArray
                    .Where(x => x > 10)
                    .Select(x => x - 10)
                    .Sum();

                Console.WriteLine(result.ToString());
                Console.Out.Flush();
            }
        }
    }
}
