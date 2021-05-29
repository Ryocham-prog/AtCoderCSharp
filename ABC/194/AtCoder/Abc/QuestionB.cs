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
        class Employee
        {
            private int _aMinutes;
            private int _bMinutes;
            private int _number;

            public Employee(int a, int b, int num)
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
                var employeesList = Enumerable.Range(0, n)
                    .Select((input, idx) => new { input = Console.ReadLine(), Index = idx })
                    .Select(x => new Employee(int.Parse(x.input.Split(' ')[0]), int.Parse(x.input.Split(' ')[1]), x.Index)).ToList();

                var aMinEmployee = employeesList.OrderBy(a => a.getMinutesA()).ElementAt(0);
                var bMinEmployee = employeesList.OrderBy(b => b.getMinutesB()).ElementAt(0);

                var aMin = aMinEmployee.getMinutesA();
                var bMin = bMinEmployee.getMinutesB();

                // 仕事A,B の最速が別人の場合
                if (aMinEmployee.getNumber() != bMinEmployee.getNumber())
                {
                    Console.WriteLine(Math.Max(aMin, bMin));
                    Console.Out.Flush();
                    return;
                }

                // 仕事A,B の最速が同じ人の場合
                var aSecond = employeesList.OrderBy(a => a.getMinutesA()).ElementAt(1).getMinutesA();
                var bSecond = employeesList.OrderBy(b => b.getMinutesB()).ElementAt(1).getMinutesB();

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
                Console.Out.Flush();
            }
        }
    }
}
