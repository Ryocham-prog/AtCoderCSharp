using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc172/tasks/abc172_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数aの入力
                var a = int.Parse(Console.ReadLine());

                var result = a + Math.Pow(a, 2) + Math.Pow(a, 3);
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
