using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc181/tasks/abc181_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:何色の服を着ているか知りたい日(N日後)
                var n = int.Parse(Console.ReadLine());
                var result = n % 2 == 0 ? "White" : "Black" ;
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
