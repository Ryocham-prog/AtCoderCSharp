using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc212/tasks/abc212_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // X1~X4の入力
                var sArray = Console.ReadLine().ToArray();

                if(sArray.GroupBy(x => x).Count() == 1)
                {
                    Console.WriteLine("Weak");
                    return;
                }

                var result = sArray
                    .Aggregate(new { isWeak = true, preVal = ' ' }, (judge, next) =>
                    {
                        if (judge.preVal == ' ') return new { isWeak = true, preVal = next };
                        if (judge.isWeak == false) return judge;

                        var tmp = judge.preVal == '9' ? '0' : (char)(judge.preVal + 1);
                        return new { isWeak = (next == tmp), preVal = next };
                    });

                var output = result.isWeak ? "Weak" : "Strong";

                Console.WriteLine(output);

                Console.Out.Flush();
            }
        }
    }
}
