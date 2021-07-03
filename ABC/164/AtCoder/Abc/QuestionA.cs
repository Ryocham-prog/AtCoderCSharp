using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc164/tasks/abc164_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // S:羊の数, W:狼の数の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"S W\")");
                    return;
                }

                var result = inputArray[0] <= inputArray[1] ? "unsafe" : "safe ";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
