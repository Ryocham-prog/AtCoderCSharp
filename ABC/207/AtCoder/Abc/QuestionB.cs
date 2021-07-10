using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc207/tasks/abc207_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // A:容器に入った水色のボールの数
                // B:1回の操作で追加される水色のボールの数
                // C:1回の操作で追加される赤色のボールの数
                // D:達成条件の倍率 (水色のボールの個数 <= 赤色のボールの個数 ×D倍)
                var inputArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
                if (inputArray.Length != 4)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"A B C D\")");
                    return;
                }

                var a = inputArray[0];
                var b = inputArray[1];
                var c = inputArray[2];
                var d = inputArray[3];

                // a + bn <= cn * d
                // ⇔ a + (b - cd)n <= 0
                // a,b,c,dは正の整数なので、 b - cd > 0のとき、条件を満たさない。
                if (b >= c * d) 
                {
                    Console.WriteLine(-1);
                    return;
                }

                long blueCnt = a;
                long redCnt = 0;
                var count = 0;
                while (blueCnt > redCnt * d)
                {
                    blueCnt += b;
                    redCnt += c;
                    count++;
                }

                Console.WriteLine(count);

                Console.Out.Flush();
            }
        }
    }
}
