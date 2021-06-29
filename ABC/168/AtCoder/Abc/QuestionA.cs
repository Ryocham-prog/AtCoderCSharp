using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc168/tasks/abc168_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:鉛筆の本数の入力
                var s = Console.ReadLine();

                var lastStr = s.Substring(s.Length - 1, 1);

                var result = string.Empty;
                switch (lastStr)
                {
                    case "2":
                    case "4":
                    case "5":
                    case "7":
                    case "9":
                        result = "hon";
                        break;

                    case "0":
                    case "1":
                    case "6":
                    case "8":
                        result = "pon";
                        break;

                    case "3":
                        result = "bon";
                        break;

                    default:
                        break;
                }

                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
