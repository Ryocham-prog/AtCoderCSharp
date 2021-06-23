using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc175/tasks/abc175_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // S:天気の記録の入力
                var s = Console.ReadLine();

                var result = s.ToArray()
                    .Aggregate(new { count = 0, isDayBeforeRainy = false }, (output, next) =>
                    {
                        var tmp = output.count;
                        if (next != 'R')
                        {
                            return new { count = tmp, isDayBeforeRainy = false };
                        }

                        if (output.isDayBeforeRainy == true)
                        {
                            tmp++;
                            return new { count = tmp, isDayBeforeRainy = true };
                        }

                        if (output.count == 0) tmp++;
                        return new { count = tmp, isDayBeforeRainy = true };
                    });

                Console.WriteLine(result.count.ToString());

                Console.Out.Flush();
            }
        }
    }
}
