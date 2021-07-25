using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc148/tasks/abc148_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 誤答A,Bの入力
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());

                var ansList = Enumerable.Range(1, 3).ToArray();

                var result = ansList
                    .Aggregate(0, (res, next) =>
                    {
                        if (next == a || next == b) return res;
                        return next;
                    });
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
