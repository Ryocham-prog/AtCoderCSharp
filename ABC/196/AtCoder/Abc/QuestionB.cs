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
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false })
            {
                Console.SetOut(sw);

                // Xの入力
                var x = Console.ReadLine().ToString();
                
                if(x.IndexOf(".") == -1)
                {
                    Console.WriteLine(x);
                    Console.Out.Flush();
                    return;
                }

                var splitX = x.Split('.');
                Console.WriteLine(splitX[0]);

                Console.Out.Flush();
            }
        }
    }
}
