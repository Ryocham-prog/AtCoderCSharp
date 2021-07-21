using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc152/tasks/abc152_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数a,bの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"a b\")");
                    return;
                }

                var a = inputArray[0];
                var b = inputArray[1];

                var minInt = Math.Min(a, b);
                var count = Math.Max(a, b);

                var tmp = Enumerable.Range(1, count)
                    .Select(x => minInt)
                    .ToArray();

                var result = String.Join("", tmp);
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
