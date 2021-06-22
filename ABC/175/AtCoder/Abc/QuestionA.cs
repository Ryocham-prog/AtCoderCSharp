using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc175/tasks/abc175_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // S:天気の記録の入力
                var s = Console.ReadLine();

                var result = s == "RRR" ? 3
                    : s.IndexOf("RR") > -1 ? 2
                    : s.IndexOf("R") > -1 ? 1 : 0;

                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
