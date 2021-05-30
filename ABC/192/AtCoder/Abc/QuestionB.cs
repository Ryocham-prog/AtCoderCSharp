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

                // 文字列の入力
                var inputArray = Console.ReadLine().ToArray()
                    .Select((input, idx) => new {input , Index = idx});

                // 奇数番目の文字列の判定
                var oddArray = inputArray.Where(x => (x.Index + 1) % 2 == 1).Where(x => Char.IsLower(x.input) == false);
                if(oddArray.Count() > 0)
                {
                    Console.WriteLine("No");
                    return;
                }

                // 偶数番目の文字列の判定
                var evenArray = inputArray.Where(x => (x.Index + 1) % 2 == 0).Where(x => Char.IsUpper(x.input) == false);
                if (evenArray.Count() > 0)
                {
                    Console.WriteLine("No");
                    return;
                }

                Console.WriteLine("Yes");
                Console.Out.Flush();
            }
        }
    }
}
