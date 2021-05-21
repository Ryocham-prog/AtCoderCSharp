using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc197/tasks/abc197_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            try
            {
                var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
                Console.SetOut(sw);

                // 整数配列(H,W,X,Y)の入力
                var inputLongArray = Console.ReadLine().Split(' ').Select(k => int.Parse(k)).ToArray();

                var hight = inputLongArray[0];
                var width = inputLongArray[1];
                var i = inputLongArray[2] - 1;
                var j = inputLongArray[3] - 1;

                var board = new List<char[]>();
                for (int idx = 0; idx < hight; idx++)
                {
                    // 文字列配列の入力
                    string s = Console.ReadLine();
                    board.Add(s.ToArray());
                }

                var count = 0;
                // 上のチェック
                for (int a = i; a >= 0; a--)
                {
                    if (board[a][j] != '.') break;
                    count++;
                }

                // 下のチェック
                for (int b = i; b < hight; b++)
                {
                    if (board[b][j] != '.') break;
                    count++;
                }

                // 左のチェック
                for (int c = j; c >= 0; c--)
                {
                    if (board[i][c] != '.') break;
                    count++;
                }

                // 右のチェック
                for (int d = j; d < width; d++)
                {
                    if (board[i][d] != '.') break;
                    count++;
                }

                Console.WriteLine(count - 3);
            }
            finally
            {
                Console.Out.Flush();
            }
        }
    }
}
