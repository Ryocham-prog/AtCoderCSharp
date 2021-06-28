using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc169/tasks/abc169_b
    class QuestionB
    {
        const long maxVal = 1000000000000000000;
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:整数の個数の入力
                var n = int.Parse(Console.ReadLine());

                // 整数配列の入力
                var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

                if(inputLongArray.Where(x => x == 0).Count() > 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                var result = inputLongArray.Aggregate(1L, (pro, next) =>
                {
                    var tmp = pro;
                    if (tmp == -1) return tmp;

                    tmp = tmp > maxVal / next ? -1 : tmp * next;

                    return tmp;
                });
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
