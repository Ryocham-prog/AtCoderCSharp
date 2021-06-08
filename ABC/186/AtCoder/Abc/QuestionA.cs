using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc186/tasks/abc186_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:トラックの容量(kg), W:レンガ一つ当たりの重さ(kg)の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N W\")");
                    return;
                }

                var result = inputArray[0] / inputArray[1];
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
