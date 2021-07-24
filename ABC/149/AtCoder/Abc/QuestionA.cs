using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc149/tasks/abc149_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列S,Tの入力
                var inputArray = Console.ReadLine().Split(' ');

                var tmp = inputArray.Reverse().ToArray();
                var result = String.Join("", tmp);
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
