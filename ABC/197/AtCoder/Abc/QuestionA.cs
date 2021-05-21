using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc197/tasks/abc197_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            try
            {
                var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
                Console.SetOut(sw);

                // 文字列の入力
                string s = Console.ReadLine();

                var result = s.Substring(1, 2) + s.Substring(0, 1);
                Console.WriteLine(result);

            }
            finally
            {
                Console.Out.Flush();
            }
        }
    }
}
