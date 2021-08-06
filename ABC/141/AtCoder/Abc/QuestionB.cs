using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc141/tasks/abc141_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列の入力
                var s = Console.ReadLine();

                var targetArray = s.ToArray()
                    .Select((x, index) => new { val = x, index = index + 1 });

                // 奇数番目の判定
                var oddBool = targetArray
                    .Where(x => x.index % 2 == 1)
                    .Aggregate(true, (judge, next) =>
                    {
                        if (judge == false) return judge;
                        return ((next.val == 'R') || (next.val == 'U') || (next.val == 'D'));
                    });

                if(!oddBool)
                {
                    Console.WriteLine("No");
                    return;
                }

                // 偶数番目の判定
                var evenBool = targetArray
                    .Where(x => x.index % 2 == 0)
                    .Aggregate(true, (judge, next) =>
                    {
                        if (judge == false) return judge;
                        return ((next.val == 'L') || (next.val == 'U') || (next.val == 'D'));
                    });

                if (!evenBool)
                {
                    Console.WriteLine("No");
                    return;
                }

                Console.WriteLine("Yes");

                Console.Out.Flush();
            }
        }
    }
}
