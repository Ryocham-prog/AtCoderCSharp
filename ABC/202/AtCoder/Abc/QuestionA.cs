using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc202/tasks/abc202_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                if (inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"a b c\")");
                    return;
                }

                var sum = inputArray.Sum(x => 7 - x);
                Console.WriteLine(sum);

                Console.Out.Flush();
            }
        }
    }
}
