using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc195/tasks/abc195_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false })
            {
                Console.SetOut(sw);

                // MとHの入力
                var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

                var result = inputLongArray[1] % inputLongArray[0] == 0 ? "Yes" : "No";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
