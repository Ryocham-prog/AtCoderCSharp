using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc154/tasks/abc154_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列の入力
                var s = Console.ReadLine();

                var replaceStrArray = s.Select(x => "x").ToArray();

                var result = String.Join("", replaceStrArray);
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
