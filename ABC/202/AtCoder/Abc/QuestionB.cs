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

                // 文字列Sの入力
                var inputArray = Console.ReadLine().ToArray();

                if (inputArray.Length == 0) return;

                var qb = new QuestionB();
                var result = inputArray.Select(input => input = qb.ReplaceStr(input)).Reverse().ToArray();
                Console.WriteLine(String.Join("", result));

                Console.Out.Flush();
            }
        }

        public char ReplaceStr(char target)
        {
            if(target == '6')
            {
                return '9';
            }

            if (target == '9')
            {
                return '6';
            }

            return target;
        }
    }
}
