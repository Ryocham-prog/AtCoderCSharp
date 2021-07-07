using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc160/tasks/abc160_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // S:文字列の入力
                var charArray = Console.ReadLine();
                if (charArray.Length != 6)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力値の長さ：\"6\")");
                    return;
                }

                var result = (charArray[2] == charArray[3] && charArray[4] == charArray[5])
                    ? "Yes" : "No";

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
