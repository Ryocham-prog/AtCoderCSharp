using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc199/tasks/abc199_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            try
            {
                var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
                Console.SetOut(sw);

                // 整数配列の入力
                var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

                var a = inputLongArray[0];
                var b = inputLongArray[1];
                var c = inputLongArray[2];

                var isYes = (a * a + b * b) < (c * c);
                Console.WriteLine(isYes ? "Yes" : "No");
            }
            finally
            {
                Console.Out.Flush();
            }
        }
    }
}
