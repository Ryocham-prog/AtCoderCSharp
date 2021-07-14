using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc157/tasks/abc157_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                var n = int.Parse(Console.ReadLine());

                var result = (n % 2 == 1) ? (n / 2 + 1) : (n / 2);
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
