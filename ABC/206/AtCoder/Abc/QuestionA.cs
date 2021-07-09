using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc206/tasks/abc206_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:税抜き価格の入力
                var n = double.Parse(Console.ReadLine());

                var price = Math.Floor(1.08 * n);
                var result = price < 206 ? "Yay!" : 
                    price == 206 ? "so-so" : ":(";

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
