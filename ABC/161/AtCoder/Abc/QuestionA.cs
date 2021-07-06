using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc161/tasks/abc161_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 箱A, B, Cに入った整数X, Y, Zの入力
                var inputArray = Console.ReadLine().Split(' ');
                if (inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"X Y Z\")");
                    return;
                }

                // AとBを入れ替え
                var tmp = inputArray[1];
                inputArray[1] = inputArray[0];
                inputArray[0] = tmp;

                tmp = inputArray[2];
                inputArray[2] = inputArray[0];
                inputArray[0] = tmp;

                Console.WriteLine(string.Join(" ", inputArray));

                Console.Out.Flush();
            }
        }
    }
}
