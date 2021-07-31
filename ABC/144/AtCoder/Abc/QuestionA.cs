using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc144/tasks/abc144_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 2つの整数A,Bの入力
                var inputArray = Console.ReadLine().Split(' ')
                    .Select(i => {
                        Int32.TryParse(i, out int tmp);
                        return tmp;
                    }).ToArray();

                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B\")");
                    return;
                }

                var a = inputArray[0];
                var b = inputArray[1];

                var result = (a < 1 || 9 < a || b < 1 || 9 < b) ? -1 : a * b;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
