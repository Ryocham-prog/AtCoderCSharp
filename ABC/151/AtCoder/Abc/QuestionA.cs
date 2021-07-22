using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc151/tasks/abc151_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // C:英小文字の入力
                var c = Convert.ToChar(Console.ReadLine());

                var result = (char)(c + 1);
                Console.WriteLine(result);

                Console.Out.Flush();

            }
        }
    }
}
