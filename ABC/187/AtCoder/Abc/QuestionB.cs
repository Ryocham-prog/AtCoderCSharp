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

                // N:点の数の入力
                var n = int.Parse(Console.ReadLine());

                // x,y:点iの座標の入力
                var inputArray = Enumerable.Range(1, n)
                    .Select(x => Console.ReadLine())
                    .Select(input => new { inputX = decimal.Parse(input.Split(' ')[0]), inputY = decimal.Parse(input.Split(' ')[1])}).ToArray();

                // (x1,y1)(x2,y2)のバリエーションを配列化
                var patternList = inputArray
                    .SelectMany(
                    (xy1, index) => inputArray.Skip(index+1).Select(xy2 => new { xy1, xy2 })
                    ).ToArray();

                var result = patternList
                    .Select(data => ((data.xy2.inputY - data.xy1.inputY) / (data.xy2.inputX - data.xy1.inputX)))
                    .Where(data => (data >= -1 && data <= 1))
                    .Count();

                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
