using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc155/tasks/abc155_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:書類に書かれた整数の入力
                var n = int.Parse(Console.ReadLine());

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
                if (inputArray.Length != n)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A1 A2 … An\")");
                    return;
                }

                // 調査対象の要素だけ抽出してチェック
                var targetArray = inputArray.Where(x => x % 2 == 0);
                var matchCount = targetArray
                                    .Where(x => x % 3 == 0 | x % 5 == 0)
                                    .Count();

                var result = matchCount == targetArray.Count() ? "APPROVED" : "DENIED";

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
