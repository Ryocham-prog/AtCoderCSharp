using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc180/tasks/abc180_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:箱に入っていたボールの数, A:取り出したボールの数, B:最後に入れたボールの数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N A B\")");
                    return;
                }

                var result = inputArray[0] - inputArray[1] + inputArray[2];
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
