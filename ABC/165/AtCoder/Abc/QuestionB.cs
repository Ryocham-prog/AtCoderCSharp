using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc165/tasks/abc165_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // X:預金判定額の入力
                var x = long.Parse(Console.ReadLine());

                var count = 0;
                decimal val = 100;
                while(val < x)
                {
                    val+= Math.Floor(val / 100);
                    count++;
                }

                Console.WriteLine(count);
                Console.Out.Flush();
            }
        }

        // 99-after-contest-01.txtがWrong Answerなので、後日検討 
        /*
          public long Calc(double val, long x, long count)
        {
             if(val >= x) return count;
         
             val += Math.Floor(val / 100);
             count++;
 
              return Calc(val, x, count);
         }
        */
    }
}
