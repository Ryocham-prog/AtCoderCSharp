using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc183/tasks/abc183_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // x:整数の入力
                var x = int.Parse(Console.ReadLine());

                var result = x < 0 ? 0 : x;
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
