using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc191/tasks/abc191_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 情報(速さV, 消え始めT, 消え終わりS, 判定位置D)の入力
                var inputintArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                if(inputintArray.Length != 4)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"V T S D\")");
                    return;
                }

                var v = inputintArray[0];
                var t = inputintArray[1];
                var s = inputintArray[2];
                var d = inputintArray[3];

                var isYes = (d < v * t || v * s < d) ? "Yes" : "No";
                Console.WriteLine(isYes);

                Console.Out.Flush();
            }
        }
    }
}
