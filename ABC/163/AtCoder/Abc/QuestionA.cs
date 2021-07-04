using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc163/tasks/abc163_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // R:半径の入力
                var n = double.Parse(Console.ReadLine());

                var result = n * 2 * Math.PI;
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
