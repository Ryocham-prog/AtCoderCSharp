using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc173/tasks/abc173_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:商品の値段の入力
                var n = int.Parse(Console.ReadLine());

                var tmp = n % 1000 != 0 ? n / 1000 + 1 : n / 1000;
                var result = 1000 * tmp - n;
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
