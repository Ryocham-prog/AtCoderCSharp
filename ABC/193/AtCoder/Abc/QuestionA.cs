using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc193/tasks/abc193_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // A,Bの入力
                var inputDoubleArray = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();
                var discount = (1 - (inputDoubleArray[1] / inputDoubleArray[0])) * 100;
                Console.WriteLine(discount);

                Console.Out.Flush();
            }
        }
    }
}
