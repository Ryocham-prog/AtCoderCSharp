using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc141/tasks/abc141_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列の入力
                var s = Console.ReadLine();

                var result = s == "Sunny" ? "Cloudy"
                    : s == "Cloudy" ? "Rainy" : "Sunny";

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
