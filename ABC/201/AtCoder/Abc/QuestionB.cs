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
        class Mountain
        {
            private string _name;
            private int _height;

            public Mountain(string name, int height)
            {
                this._name = name;
                this._height = height;
            }

            public string getName()
            {
                return _name;
            }
            public int getHeight()
            {
                return _height;
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
                Console.SetOut(sw);

                // 山の数の入力
                var n = int.Parse(Console.ReadLine());

                var list = new List<Mountain>();
                for (int i = 0; i < n; i++)
                {
                    // 山の情報の入力
                    string[] inputStrArray = Console.ReadLine().Split(' ');
                    list.Add(new Mountain(inputStrArray[0], int.Parse(inputStrArray[1])));
                }

                // 高い順に並び替えて、2番目の山の名称を出力
                list.Sort((a, b) => b.getHeight() - a.getHeight());
                Console.WriteLine(list[1].getName());
            }
            finally
            {
                Console.Out.Flush();
            }
        }
    }
}
