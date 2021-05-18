using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc199/tasks/abc199_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            try
            {
                var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
                Console.SetOut(sw);

                // 数列の長さの入力
                long n = long.Parse(Console.ReadLine());

                // 数列Aの入力
                var arrayA = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                // 数列Bの入力
                var arrayB = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                var aMax = arrayA.Max();
                var bMin = arrayB.Min();

                if (aMax > bMin)
                {
                    Console.WriteLine("0");
                    return;
                }

                var xCount = Enumerable.Range(aMax, bMin - aMax +1).Count() ;
                Console.WriteLine(xCount.ToString());
            }
            finally
            {
                Console.Out.Flush();
            }
        }
    }
}
