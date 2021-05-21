using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc198/tasks/abc198_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            try
            {
                var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
                Console.SetOut(sw);

                // 整数の入力
                long n = long.Parse(Console.ReadLine());

                // 末尾の0を削る
                while(n != 0 && n % 10 == 0)
                {
                    n /= 10;
                }

                var target = n.ToString();
                var targetLen = target.Length;
                var loopCnt = targetLen / 2;
                for (int i = 0; i < loopCnt; i++)
                {
                    if (target.Substring(i, 1) != target.Substring(targetLen - 1 - i, 1))
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }

                Console.WriteLine("Yes");
            }
            finally
            {
                Console.Out.Flush();
            }
        }
    }
}
