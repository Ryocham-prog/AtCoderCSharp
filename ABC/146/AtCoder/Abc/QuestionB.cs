using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc146/tasks/abc146_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                Int32.TryParse(Console.ReadLine(), out int n);

                // 文字列の入力
                var s = Console.ReadLine();

                var result = s.ToArray()
                    .Aggregate(new StringBuilder(), (output, next) =>
                    {
                        var tmp = next - 'A' + n;
                        if (tmp >= 26) tmp %= 26;
                        return output.Append((char)(tmp + 'A'));
                    }).ToString();

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
