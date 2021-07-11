using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc208/tasks/abc208_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // P:商品の価格の入力
                var p = int.Parse(Console.ReadLine());

                var coinArray = Enumerable.Range(1, 10)
                    //.Select((val, index) => new { val, index })
                    .Select(x => {
                        return Enumerable.Range(1, x)
                        .Aggregate(1, (product, next) =>
                        {
                            return product * next;
                        });
                      })
                    .OrderByDescending(x => x)
                    .ToArray();

                var result = coinArray
                    .Aggregate(new { coinCnt = 0, payment = p }, (info, next) =>
                    {
                        if (info.payment == 0) return info;

                        var tmp = info.payment / next;
                        if (tmp > 100) return new { coinCnt = info.coinCnt + 100, payment = info.payment - next * 100 };


                        return new { coinCnt = info.coinCnt + tmp, payment = info.payment - next * tmp };
                    })
                    .coinCnt;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
