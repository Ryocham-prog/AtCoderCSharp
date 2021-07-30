using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc145/tasks/abc145_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                Int32.TryParse(Console.ReadLine(), out int n);

                // 文字列の入力
                var s = Console.ReadLine();
                if (n % 2 == 1)
                {
                    Console.WriteLine("No");
                    return;
                }

                var result = (s.Substring(0, n / 2) == s.Substring(n / 2, n / 2)) 
                    ? "Yes" : "No";

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
