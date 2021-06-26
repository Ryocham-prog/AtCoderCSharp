using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc171/tasks/abc171_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // α：英文字の入力
                var s = Console.ReadLine();

                var result = s.ToUpper() == s ? "A" : "a";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
