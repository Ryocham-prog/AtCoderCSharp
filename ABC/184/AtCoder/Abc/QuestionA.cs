using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc184/tasks/abc184_a
    public class QuestionA
    {
        class XYAxis
        {
            private int _xAxis;
            private int _yAxis;

            public XYAxis(int xAxis, int yAxis)
            {
                this._xAxis = xAxis;
                this._yAxis = yAxis;
            }

            public int GetXAxis()
            {
                return _xAxis;
            }

            public int GetYAxis()
            {
                return _yAxis;
            }
        }
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 行列情報の入力
                var inputArray = Enumerable.Range(1, 2)
                    .Select(x => Console.ReadLine())
                    .Select(x => new XYAxis(int.Parse(x.Split(' ')[0]), int.Parse(x.Split(' ')[1])))
                    .ToArray();

                var result = inputArray[0].GetXAxis() * inputArray[1].GetYAxis() - inputArray[0].GetYAxis() * inputArray[1].GetXAxis();
                Console.WriteLine(result.ToString());

                Console.Out.Flush();
            }
        }
    }
}
