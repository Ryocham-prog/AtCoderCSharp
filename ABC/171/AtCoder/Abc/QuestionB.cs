using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc171/tasks/abc171_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:果物の種類, K:果物の種類の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N K\")");
                    return;
                }

                var n = inputArray[0];
                var k = inputArray[1];
                if (k < n) 
                {
                    Console.Error.WriteLine("入力値Kを確認してください。(入力制約：1≦K≦N≦1000)");
                    return;
                }

                var priceArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != n)
                {
                    Console.Error.WriteLine("果物の価格はN個入力してください。");
                    return;
                }

                var result = priceArray
                    .OrderBy(x => x)
                    .Take(k)
                    .Sum();

                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
