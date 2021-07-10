using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc207/tasks/abc207_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数配列A, B, Cの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                var result = inputArray
                    .OrderByDescending(x => x)
                    .Take(2)
                    .Sum();

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
