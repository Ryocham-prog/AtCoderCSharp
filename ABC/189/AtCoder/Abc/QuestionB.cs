using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc189/tasks/abc189_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:飲んだお酒の総数, X:酔っぱらうアルコール摂取量の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N X\")");
                    return;
                }

                var n = inputArray[0];
                var x = inputArray[1] * 100;    // 整数で計算するため、100倍する

                // 飲んだお酒の情報(V:お酒の量, P:アルコール度数(%))の入力
                var alcoholInfoArray = Enumerable.Range(1, n)
                    .Select(input => Console.ReadLine())
                    .Select((input, index) => new { alcohol = int.Parse(input.Split(' ')[0]) * int.Parse(input.Split(' ')[1]), index })
                    .ToArray();

                var result = alcoholInfoArray
                    .Aggregate(new { alcohol = 0, index = 0 }, (sum, next) =>
                    {
                        var tmp = sum.alcohol;
                        if (tmp > x)
                        {
                            return sum;
                        }
                        tmp += next.alcohol;
                        return new { alcohol = tmp, index = next.index };
                    });
                var output = result.alcohol <= x ? "-1" : (result.index + 1).ToString();
                Console.WriteLine(output);
                Console.Out.Flush();
            }
        }
    }
}
