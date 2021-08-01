using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc210/tasks/abc210_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ')
                    .Select(i => {
                        Int32.TryParse(i, out int tmp);
                        return tmp;
                    }).ToArray();
                if (inputArray.Length != 4)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N A X Y\")");
                    return;
                }

                var n = inputArray[0];
                var a = inputArray[1];
                var x = inputArray[2];
                var y = inputArray[3];

                if(n <= a)
                {
                    Console.WriteLine(x * n);
                    return;
                }

                Console.WriteLine((x * a) + (y * (n - a)));

                Console.Out.Flush();
            }
        }
    }
}
