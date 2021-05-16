using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc201/tasks/abc201_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 山の数の入力
            long n = long.Parse(Console.ReadLine());

            var mountainArray = new Dictionary<string, long>();

            for(int i = 0; i < n; i++)
            {
                // 山の情報の入力
                string[] inputStrArray = Console.ReadLine().Split(' ');
                mountainArray.Add(inputStrArray[0], int.Parse(inputStrArray[1]));
            }
            // 高さで並べ替えて、2番目の名称を出力
            var sortArray = mountainArray.OrderByDescending(v => v.Value);
            var result = sortArray.ElementAt(1).Key;

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
