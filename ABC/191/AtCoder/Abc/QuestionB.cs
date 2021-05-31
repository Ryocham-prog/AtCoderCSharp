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

                // N,Xの入力
                var inputintArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                var inputN = inputintArray[0];
                var inputX = inputintArray[1].ToString();

                // 整数列Aの入力
                var targetArray = Console.ReadLine().Split(' ')
                    .Where(a => a != inputX).ToArray();

                if (targetArray.Length == 0)
                {
                    Console.WriteLine();
                    return;
                }

                Console.WriteLine(String.Join(" ", targetArray));

                Console.Out.Flush();
            }
        }
    }
}
