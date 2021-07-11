using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc208/tasks/abc208_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // A:サイコロを振る回数, B:出た目の合計期待値の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B\")");
                    return;
                }


                var a = inputArray[0];
                var b = inputArray[1];

                var result = ((1 * a) <= b) && (b <= (6 * a)) ? "Yes" : "No" ;

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
