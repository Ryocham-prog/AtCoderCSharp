using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc141/tasks/abc141_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列配列の入力
                var inputArray = Console.ReadLine().ToArray();

                var filterArray = inputArray.GroupBy(x => x).Where(x => x.Count() == 3).ToArray();
                var result = filterArray.Count() == 1 ? "Won" : "Lost";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
