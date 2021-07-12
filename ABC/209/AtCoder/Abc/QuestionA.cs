using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc209/tasks/abc209_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // A,Bの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B\")");
                    return;
                }

                var a = inputArray[0];
                var b = inputArray[1];

                if(a > b)
                {
                    Console.WriteLine(0);
                    return;
                }

                Console.WriteLine(inputArray[1] - inputArray[0] + 1);

                Console.Out.Flush();
            }
        }
    }
}
