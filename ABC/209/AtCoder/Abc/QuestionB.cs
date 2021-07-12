using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc209/tasks/abc209_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:商品の数, X:所持金の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N X\")");
                    return;
                }

                var n = inputArray[0];
                var x = inputArray[1];

                var totalAmount = Console.ReadLine().Split(' ')
                    .Select((i, index) =>
                    {
                        return (index + 1) % 2 == 0 ? int.Parse(i) - 1 : int.Parse(i);
                    })
                    .Sum();


                var result = totalAmount <= x ? "Yes" : "No";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
