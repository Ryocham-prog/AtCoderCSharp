using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc140/tasks/abc140_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                if(!Int32.TryParse(Console.ReadLine(), out int n))
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= n <= 9\")");
                    return;
                }

                var result = Math.Pow(n, 3);

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
