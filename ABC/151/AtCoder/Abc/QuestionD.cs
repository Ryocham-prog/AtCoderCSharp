using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionD
    {
        class Field
        {
            private int _h;
            private int _w;
            private int _num;

            public Field(int h, int w, int num)
            {
                this._h = h;
                this._w = w;
                this._num = num;
            }

            public int getHeight()
            {
                return _h;
            }
            public int getWidth()
            {
                return _w;
            }
            public int getCount()
            {
                return _num;
            }
        }

        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数の入力
                var inputArray = Console.ReadLine().Split(' ')
                    .Select(i =>
                    {
                        var success = Int32.TryParse(i, out int tmpVal);
                        return new { success, val = tmpVal };
                    }).ToArray();

                if (inputArray.Where(x => !(x.success)).Count() > 0)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"1 <= H,W <= 20\")");
                    return;
                }

                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"H W\")");
                    return;
                }

                var h = inputArray[0].val;
                var w = inputArray[1].val;

                var map = Enumerable.Range(1, h)
                    .Select(x => Console.ReadLine().ToArray())
                    .ToArray();

                var max = 0;
                var mH = new int[] { 1, -1, 0, 0 };
                var mW = new int[] { 0, 0, 1, -1 };
                for (var i = 0; i < h; i++)
                {
                    for (var j = 0; j < w; j++)
                    {
                        if (map[i][j] == '#') continue;

                        var visited = new bool[h][];
                        visited[i][j] = true;
                        // ↑nullなので例外発生。後で対処する。

                        var start = new Field(i, j, 0);
                        var queue = new Queue<Field>();
                        queue.Enqueue(start);
                        while (queue.Count() > 0)
                        {
                            var count = queue.Count();
                            for (int k = 0; k < count; k++)
                            {
                                var wk = queue.Dequeue();
                                var wkCount = wk.getCount() + 1;
                                for (var l = 0; l < 4; l++)
                                {
                                    var wkH = mH[l] + wk.getHeight();
                                    var wkW = mW[l] + wk.getWidth();
                                    if (wkH < 0 || wkH >= h || wkW < 0 || wkW >= w)
                                        continue;
                                    if (visited[wkH][wkW])
                                        continue;
                                    visited[wkH][wkW] = true;
                                    if (map[wkH][wkW] == '#')
                                        continue;
                                    queue.Enqueue(new Field(wkH, wkW, wkCount));
                                    max = Math.Max(max, wkCount);
                                }
                            }
                        }
                    }
                }

                Console.WriteLine(max);

                Console.Out.Flush();
            }
        }
    }
}
