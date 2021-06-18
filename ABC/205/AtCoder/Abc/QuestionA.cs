using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc205/tasks/abc205_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // A:100mLあたりのエネルギー(kcal), B:ドリンクの量(mL)の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B\")");
                    return;
                }
                var result = inputArray[0] * inputArray[1] / 100;

                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
