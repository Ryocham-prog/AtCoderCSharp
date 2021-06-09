using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc185/tasks/abc185_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 問題の案(A1,A2,A3,A4)の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

                var result = inputArray.Min();
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
