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

                // 文字列の入力
                string s = Console.ReadLine();

                var len = s.Length;
                var nStr = new StringBuilder(s);
                for (int i = 0; i < len; i++)
                {
                    if (s.Substring(len - 1 - i, 1) != "0") break;
                    nStr.Insert(0, "0");
                }

                var target = nStr.ToString();
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
