using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc170/tasks/abc170_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // X:動物の数, Y:足の数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                var x = inputArray[0];
                var y = inputArray[1];

                var headArray = Enumerable.Range(0, x + 1)
                    .Select(input => new { crane = input, turtle = x - input })
                    .ToArray();

                var result = headArray
                    .Aggregate(false, (judge, next) =>
                    {
                        var tmp = judge;
                        if (tmp == true) return tmp;

                        var cr = next.crane;
                        var tu = next.turtle;
                        if (2 * cr + 4 * tu == y) return true;

                        return judge;
                    });

                var outStr = result == true ? "Yes" : "No";

                Console.WriteLine(outStr);

                Console.Out.Flush();
            }
        }
    }
}
