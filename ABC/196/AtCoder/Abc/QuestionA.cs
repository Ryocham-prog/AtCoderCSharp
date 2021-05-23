using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc196/tasks/abc196_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false })
            {

                Console.SetOut(sw);

                // xの範囲の入力
                var xRange = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

                // yの範囲の入力
                var yRange = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

                // xの最大値からyの最小値を引いて出力
                Console.WriteLine(xRange[1]-yRange[0]);

                Console.Out.Flush();
            }
        }
    }
}
