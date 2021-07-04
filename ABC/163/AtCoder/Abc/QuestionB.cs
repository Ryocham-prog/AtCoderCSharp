using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc163/tasks/abc163_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:夏休みの日数, M:宿題の数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N M\")");
                    return;
                }

                var n = inputArray[0];
                var m = inputArray[1];

                var homeworkDays = Console.ReadLine().Split(' ')
                    .Select(i => int.Parse(i))
                    .ToArray()
                    .Sum();

                var result = n - homeworkDays;
                if (result < 0) result = -1;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
