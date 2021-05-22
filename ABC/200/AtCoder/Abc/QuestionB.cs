using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc200/tasks/abc200_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            try
            {
                var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
                Console.SetOut(sw);

                // 整数配列の入力
                var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

                var n = inputLongArray[0];
                var k = inputLongArray[1];

                for (int i = 0; i < k; i++)
                {
                    if (n % 200 == 0)
                    {
                        n /= 200;
                    }
                    else
                    {
                        n = n * 1000 + 200;
                    }
                }

                Console.WriteLine(n.ToString());
            }
            finally
            {
                Console.Out.Flush();
            }
        }
    }
}
