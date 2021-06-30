using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc167/tasks/abc167_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // S:旧ID候補の入力
                var s = Console.ReadLine();

                // T:新ID候補の入力
                var t = Console.ReadLine();

                if ((s.Length + 1) != t.Length)
                {
                    Console.WriteLine("No");
                    return;
                }

                var result = (s == t.Substring(0, s.Length)) ? "Yes" : "No";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
