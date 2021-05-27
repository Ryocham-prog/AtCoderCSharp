using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc194/tasks/abc194_b
    class QuestionB
    {
        class Employees
        {
            private int _aMinutes;
            private int _bMinutes;
            private int _number;

            public Employees(int a, int b, int num)
            {
                this._aMinutes = a;
                this._bMinutes = b;
                this._number = num;
            }

            public int getMinutesA()
            {
                return _aMinutes;
            }
            public int getMinutesB()
            {
                return _bMinutes;
            }
            public int getNumber()
            {
                return _number;
            }
        }

        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false })
            {
                Console.SetOut(sw);

                // 従業員数(N)の入力
                var n = int.Parse(Console.ReadLine());

                // 従業員の仕事A,Bにおける所要時間の入力
                var stringList = Enumerable.Range(0, n).Select(x => Console.ReadLine()).ToList();

                var employeesList = new List<Employees>();
                var i = 0;
                foreach (var employee in stringList)
                {
                    employeesList.Add(new Employees(int.Parse(employee.Split(' ')[0]), int.Parse(employee.Split(' ')[1]), i));
                    i++;
                }

                var listOrderByA = new List<Employees>(employeesList.OrderBy(a => a.getMinutesA()));
                var listOrderByB = new List<Employees>(employeesList.OrderBy(b => b.getMinutesB()));

                var aMin = listOrderByA.ElementAt(0).getMinutesA();
                var bMin = listOrderByB.ElementAt(0).getMinutesB();

                // 仕事A,B の最速が同じ人の場合
                if (listOrderByA.ElementAt(0).getNumber() == listOrderByB.ElementAt(0).getNumber())
                {
                    var aSecond = listOrderByA.ElementAt(1).getMinutesA();
                    var bSecond = listOrderByB.ElementAt(1).getMinutesB();

                    // 仕事Aを最速の人がやる場合
                    var FastA = Math.Max(aMin, bSecond);

                    // 仕事Bを最速の人がやる場合
                    var FastB = Math.Max(aSecond, bMin);

                    // 仕事A,B両方を最速の人がやる場合
                    var bothAB = aMin + bMin;

                    // 一番短い時間を求める
                    var min = 0;
                    if (FastA < FastB)
                    {
                        min = FastA;
                    }
                    else
                    {
                        min = FastB;
                    }

                    if (bothAB < min) min = bothAB;

                    Console.WriteLine(min);
                }
                // 仕事A,B の最速が別人の場合
                else
                {
                    Console.WriteLine(Math.Max(aMin, bMin));
                }
                Console.Out.Flush();
            }
        }
    }
}
