using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc145/tasks/abc145_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                Int32.TryParse(Console.ReadLine(), out int n);

                Console.WriteLine(Math.Pow(n, 2));

                Console.Out.Flush();
            }
        }
    }
}
