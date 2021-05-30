using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc192/tasks/abc192_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // コインの枚数の入力
                var n = int.Parse(Console.ReadLine());

                Console.WriteLine((100 - n % 100).ToString());
                Console.Out.Flush();
            }
        }
    }
}
