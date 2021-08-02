using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc211/tasks/abc211_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                var strList = Enumerable.Range(1, 4)
                    .Select(x => Console.ReadLine())
                    .ToArray();

                // 制約により、H , 2B , 3B , HR のいずれかと一致することが確定しているので↓
                var result = strList.GroupBy(x => x).Count() == 4 ? "Yes" : "No";
                Console.WriteLine(result);

                Console.Out.Flush();
            }
        }
    }
}
