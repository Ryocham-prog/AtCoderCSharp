using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc200/tasks/abc200_a
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
                var century = ((n - 1) / 100) + 1;

                Console.WriteLine(century.ToString());
            }
            finally
            {
                Console.Out.Flush();
            }
        }
    }
}
