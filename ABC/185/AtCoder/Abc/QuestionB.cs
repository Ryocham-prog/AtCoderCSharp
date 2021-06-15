using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc185/tasks/abc185_b
    class QuestionB
    {
        class CafeTime
        {
            private int _enterTime;
            private int _leaveTime;

            public int EnterTime
            {
                set{ this._enterTime = value;}
                get{ return this._enterTime; }
            }

            public int LeaveTime
            {
                set { this._leaveTime = value; }
                get { return this._leaveTime; }
            }
        }

        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {

                Console.SetOut(sw);

                // N:バッテリー容量, M:カフェの訪問回数, T:帰宅時刻の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if (inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N M T\")");
                    return;
                }

                var n = inputArray[0];
                var m = inputArray[1];
                var t = inputArray[2];

                // A:カフェ入室時間, B:カフェ退室時間の入力
                var cafeTimeList = Enumerable.Range(1, m)
                    .Select(x => Console.ReadLine())
                    .Select(x => new CafeTime { EnterTime = int.Parse(x.Split(' ')[0]), LeaveTime = int.Parse(x.Split(' ')[1])})
                    .ToList();

                var battery = n;
                var leaveTime = 0;
                var check = cafeTimeList.Aggregate(0, (sum, next) =>
                {
                    var enterTime = next.EnterTime;
                    // カフェに着くまでのバッテリー残量をチェック
                    battery -= enterTime - leaveTime;
                    if (battery < 1)
                    {
                        return 0;
                    }

                    // カフェにいる間の充電ぶんを加算
                    leaveTime = next.LeaveTime;
                    battery += leaveTime - enterTime;
                    if (battery > n) battery = n;
                    return battery;
                });

                // 最後のカフェから帰宅までのバッテリー消費ぶんを減算
                battery -= t - leaveTime;

                var result = battery < 1 ? "No" : "Yes";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
