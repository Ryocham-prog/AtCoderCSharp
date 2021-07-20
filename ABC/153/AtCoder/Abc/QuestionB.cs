using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc153/tasks/abc153_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // H:体力, N:技の種類の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"H N\")");
                    return;
                }

                var h = inputArray[0];
                var n = inputArray[1];

                // 整数配列の入力
                var attackInfo = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                var result = attackInfo.Sum() >= h ? "Yes" : "No" ;
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
