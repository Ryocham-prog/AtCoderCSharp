using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc160/tasks/abc160_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                var n = int.Parse(Console.ReadLine());

                var thousandCount = n / 500;
                var hundredCount = (n - 500 * thousandCount) / 5;

                var result = (1000 * thousandCount) + (5 * hundredCount);

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
