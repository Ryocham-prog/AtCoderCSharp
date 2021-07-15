using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc156/tasks/abc156_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:整数, K:進数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N K\")");
                    return;
                }

                var n = inputArray[0];
                var k = inputArray[1];

                var result = 0;
                while(n > 0)
                {
                    n /= k;
                    result++;
                }

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
