using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abc193/tasks/abc193_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                Console.SetOut(sw);

                // 販売店舗数の入力
                var n = int.Parse(Console.ReadLine());

                // 店舗情報(A,P,X)の入力
                var shopList = Enumerable.Range(0, n)
                    .Select(input => new { input = Console.ReadLine().Split(' ') })
                    .Select(x => new { time = long.Parse(x.input[0]), price = long.Parse(x.input[1]), stock = long.Parse(x.input[2]) }).ToList();

                var ableShop = shopList.Where(x => (x.stock - x.time) >= 1).OrderBy(x => x.price).ToList();

                if(ableShop.Count == 0)
                {
                    Console.WriteLine("-1");
                    return;
                }
                Console.WriteLine(ableShop.ElementAt(0).price);
                Console.Out.Flush();
            }
        }
    }
}
