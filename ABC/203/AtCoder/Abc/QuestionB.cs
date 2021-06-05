using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        // https://atcoder.jp/contests/abc203/tasks/abc203_b
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 階層Nと部屋数Kの入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if(inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N K\")");
                    return;
                }

                var floorInput = inputArray[0];
                var roomInput = inputArray[1];

                // 1階だけの合計値を算出(a)
                var firstFloorSum = Enumerable.Range(101, roomInput).Sum();
                if(floorInput == 1)
                {
                    Console.WriteLine(firstFloorSum.ToString());
                    return;
                }

                //  2階以上の場合、100の位の増加分を考慮して、
                //  100 + 部屋数 * (階層 - 1)を足す
                var highFloorHundredsSum = Enumerable.Range(2, floorInput - 1)
                    .Select(n => 100 * roomInput * (n - 1)).Sum();

                var allFloorSum = firstFloorSum * floorInput + highFloorHundredsSum;
                Console.WriteLine(allFloorSum.ToString()) ;

                Console.Out.Flush();
            }
        }
    }
}
