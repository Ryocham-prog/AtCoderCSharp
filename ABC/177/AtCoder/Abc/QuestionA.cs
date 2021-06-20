using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc177/tasks/abc177_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // D:待ち合わせ場所までの距離, T:待ち合わせまでの時間, S:分速の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"D T S\")");
                    return;
                }

                var result = inputArray[0] > inputArray[1] * inputArray[2] ? "No" : "Yes";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
