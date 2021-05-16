using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc201/tasks/abc201_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            string result = "";
            if (inputLongArray[0] == inputLongArray[1] && inputLongArray[1] == inputLongArray[2])
            {
                result = "Yes";
            }
            else
            {
                Array.Sort(inputLongArray);
                if (inputLongArray[1] - inputLongArray[0] == inputLongArray[2] - inputLongArray[1])
                {
                    result = "Yes";
                }
                else
                {
                    result = "No";
                }
            }
            Console.WriteLine(result);
            Console.Out.Flush();
        }
    }
}
