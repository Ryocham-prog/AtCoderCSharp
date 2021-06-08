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

                // H:縦のマスの数, W:横のマスの数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"H W\")");
                    return;
                }

                // 各行のブロック数を入力
                var blockInfo = Enumerable.Range(1, inputArray[0])
                    .Select(input => Console.ReadLine())
                    .Select(input => new { blockCount = input.Split(' ').Select(i => int.Parse(i)) })
                    .SelectMany(input => input.blockCount)
                    .ToArray();

                var minBlockCount = blockInfo.Min();
                var result = blockInfo
                    .Select(blockCount => blockCount - minBlockCount)
                    .Sum();

                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
