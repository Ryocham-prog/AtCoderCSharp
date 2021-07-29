using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc146/tasks/abc146_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列の入力
                var s = Console.ReadLine();

                var tmp = s == "SUN" ? 0
                    : s == "MON" ? 1
                    : s == "TUE" ? 2
                    : s == "WED" ? 3
                    : s == "THU" ? 4
                    : s == "FRI" ? 5 : 6;

                var result = 7 - tmp;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
