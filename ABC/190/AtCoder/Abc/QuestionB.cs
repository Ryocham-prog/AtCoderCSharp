using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // N:呪文の種類、S:詠唱に掛かる時間のNG基準値、D:威力のNG基準値の入力
                var inputArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                if(inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"N S D\")");
                    return;
                }

                var n = inputArray[0];
                var s = inputArray[1];
                var d = inputArray[2];

                var magicInfoArray = Enumerable.Range(1, n)
                    .Select(input => Console.ReadLine())
                    .Select((input, index) => new { x = int.Parse(input.Split(' ')[0]), y = int.Parse(input.Split(' ')[1]) , index });

                // 詠唱がS秒未満の呪文チェック
                var xCheckArray = magicInfoArray.Where(time => time.x < s);

                // 上記チェックでOK、かつ威力がDより大きい呪文チェック
                var yCheckArray = xCheckArray.Where(power => power.y > d);

                var result = yCheckArray.Count() > 0 ? "Yes" : "No";
                Console.WriteLine(result);
            }
        }
    }
}
