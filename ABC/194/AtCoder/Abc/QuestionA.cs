using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc194/tasks/abc194_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false })
            {
                Console.SetOut(sw);

                // A,Bの入力
                var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

                var a = inputLongArray[0];
                var b = inputLongArray[1];

                if (a + b >= 15 && b >= 8)
                {
                    Console.WriteLine(1);
                }
                else if (a + b >= 10 && b >= 3)
                {
                    Console.WriteLine(2);
                }
                else if (a + b >= 3)
                {
                    Console.WriteLine(3);
                }
                else
                {
                    Console.WriteLine(4);
                }

                Console.Out.Flush();
            }

        }
    }
}
