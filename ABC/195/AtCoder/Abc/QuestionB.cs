using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc195/tasks/abc195_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false })
            {
                Console.SetOut(sw);

                // A,B,Wの入力
                var inputDecimalArray = Console.ReadLine().Split(' ').Select(i => decimal.Parse(i)).ToArray();

                var a = inputDecimalArray[0];
                var b = inputDecimalArray[1];
                var w = inputDecimalArray[2] * 1000;

                var min = Math.Ceiling(w / b) ;
                var max = Math.Floor(w / a);

                var result = min > max ? "UNSATISFIABLE" : $"{min} {max}";

                Console.WriteLine(result);
                Console.Out.Flush();
            }
        }
    }
}
