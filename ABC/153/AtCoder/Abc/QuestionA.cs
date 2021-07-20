using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc153/tasks/abc153_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // H:体力, A:一回の攻撃で減る体力の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"H A\")");
                    return;
                }

                var h = inputArray[0];
                var a = inputArray[1];
                var result = h % a == 0 ? h / a : h / a + 1;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
