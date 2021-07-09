using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc206/tasks/abc206_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                var n = int.Parse(Console.ReadLine());

                var q = new QuestionB();
                var output = q.Add(n, 0, 1);

                Console.WriteLine(output);

                Console.Out.Flush();
            }
        }

        private int Add(int n, int savings, int days)
        {
            if (savings >= n) return days - 1;

            savings += days;
            days++;
            var result = Add(n, savings, days);

            return result;
        }
    }
}
