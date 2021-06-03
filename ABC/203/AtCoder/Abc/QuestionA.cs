using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc203/tasks/abc203_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 整数配列の入力
                var inputArray = Console.ReadLine().Split(' ').ToArray();
                if(inputArray.Length != 3)
                {
                    Console.Error.WriteLine("入力値を確認してください。(入力形式：\"a b c\")");
                    return;
                }

                var filterArray = inputArray.GroupBy(x => x).Where(x => x.Count() == 1).ToList();
                // 1つも同じ目がない場合
                if(filterArray.Count == 3)
                {
                    Console.WriteLine("0");
                    return;
                }

                // 3つとも同じ目の場合
                if (filterArray.Count == 0)
                {
                    Console.WriteLine(inputArray[0]);
                    return;
                }

                // 2つ同じ目の場合
                Console.WriteLine(filterArray[0].Key);

                Console.Out.Flush();
            }
        }
    }
}
