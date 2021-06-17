using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc204/tasks/abc204_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // x:フェネックが出した手, y:アライグマが出した手の入力
                var inputArray = Console.ReadLine().Split(' ');
                if (inputArray.Length != 2)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"X Y\")");
                    return;
                }

                if (inputArray[0] == inputArray[1])
                {
                    Console.WriteLine(inputArray[0]);
                    return;
                }

                var result = (inputArray.Where(item => item == "0").Count() == 0) ? "0"
                    : (inputArray.Where(item => item == "1").Count() == 0) ? "1" : "2" ;

                Console.WriteLine(result);
                Console.Out.Flush();
            }
        }
    }
}
