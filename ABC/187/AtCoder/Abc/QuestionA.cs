using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc187/tasks/abc187_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列配列の入力
                var inputArray = Console.ReadLine().Split(' ');
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B\")");
                    return;
                }

                var sumA = inputArray[0].ToArray()
                    .Select(x => int.Parse(x.ToString()))
                    .Sum();

                var sumB = inputArray[1].ToArray()
                    .Select(x => int.Parse(x.ToString()))
                    .Sum();

                var result = sumA >= sumB ? sumA : sumB;
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
