using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc147/tasks/abc147_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => {
                    Int32.TryParse(i, out int tmpParse);
                    return tmpParse;
                }).ToArray();
                var tmp = inputArray.Sum() ;
                var result = tmp < 22 ? "win" : "bust";

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
