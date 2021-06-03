using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc202/tasks/abc202_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 文字列Sの入力
                var inputArray = Console.ReadLine().ToArray();

                if (inputArray.Length == 0)
                {
                    Console.Error.WriteLine("0,1,6,8,9 からなる文字列を入力してください。");
                    return;
                }

                var result = inputArray
                    .Select(input => input = input == '6' ? 'X' : input)
                    .Select(input => input = input == '9' ? '6' : input)
                    .Select(input => input = input == 'X' ? '9' : input)
                    .Reverse().ToArray();
                Console.WriteLine(String.Join("", result));

                Console.Out.Flush();
            }
        }
    }
}
