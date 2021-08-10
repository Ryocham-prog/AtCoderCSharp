using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc138/tasks/abc138_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                if(!Int32.TryParse(Console.ReadLine(), out int a))
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"2800 <= a <= 5000\")");
                    return;
                }

                // 文字列の入力
                var s = Console.ReadLine();

                var result = a >= 3200 ? s : "red";

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
