using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc158/tasks/abc158_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列の入力
                var s = Console.ReadLine();

                var result = s.ToArray().GroupBy(x => x).Count() > 1 ? "Yes" : "No" ;
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
