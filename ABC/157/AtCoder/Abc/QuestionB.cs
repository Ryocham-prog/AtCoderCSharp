using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc157/tasks/abc157_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // ビンゴのカード情報の入力
                var bingoArray = Enumerable.Range(1, 3)
                    .Select(x => Console.ReadLine())
                    .Select(x =>
                    {
                        var tmp = x.Split(' ').Select(y => int.Parse(y)).ToArray();
                        return tmp;
                    })
                    .ToArray();


                // 選ぶ数字の入力
                var n = int.Parse(Console.ReadLine());

                var inputArray = Enumerable.Range(1, n)
                    .Select(x => int.Parse(Console.ReadLine()))
                    .ToArray();

                var flgArray = new int[][] {
                    new int[]{ 0,0,0 },
                    new int[]{ 0,0,0 },
                    new int[]{ 0,0,0 }
                };

                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        if (inputArray.Contains(bingoArray[i][j])) flgArray[i][j] = 1;
                    }
                }

                // 横方向のチェック
                var rowCheck = flgArray.Aggregate(false, (rowResult, next) =>
                {
                    if (rowResult) return true;
                    var tmp = next.Where(x => x == 1).Count();
                    return (tmp == 3);
                });

                if (rowCheck)
                {
                    Console.WriteLine("Yes");
                    return;
                }

                // 縦方向のチェック
                for (var i = 0; i < 3; i++)
                {
                    var colCheck = true;
                    for (var j = 0; j < 3; j++)
                    {
                        if (!colCheck) break;
                        if (flgArray[j][i] == 0 ) colCheck = false;
                    }
                    if (colCheck)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }

                // ナナメのチェック
                if (flgArray[0][0] == 1 && flgArray[1][1] == 1 && flgArray[2][2] == 1)
                {
                    Console.WriteLine("Yes");
                    return;
                }

                if (flgArray[0][2] == 1 && flgArray[1][1] == 1 && flgArray[2][0] == 1)
                {
                    Console.WriteLine("Yes");
                    return;
                }

                Console.WriteLine("No");

                Console.Out.Flush();
            }
        }
    }
}
