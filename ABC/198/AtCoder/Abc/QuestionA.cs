using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc198/tasks/abc198_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            try
            {
                var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
                Console.SetOut(sw);

                // 整数の入力
                long n = long.Parse(Console.ReadLine());

                if (n < 2)
                {
                    Console.WriteLine(0);
                    return;
                }

                Console.WriteLine(n - 1);
            }
            finally
            {
                Console.Out.Flush();
            }
        }
    }
}
