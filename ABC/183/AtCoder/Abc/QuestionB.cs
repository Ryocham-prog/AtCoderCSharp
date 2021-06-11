using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc183/tasks/abc183_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // S(x,y), G(x,y)の座標入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => decimal.Parse(i)).ToArray();
                if (inputArray.Length != 4)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"Sx Sy Gx Gy\")");
                    return;
                }

                var sx = inputArray[0];
                var sy = inputArray[1];
                var gx = inputArray[2];
                var gy = inputArray[3];

                var result = (sx * gy + gx * sy) / (sy + gy);
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
