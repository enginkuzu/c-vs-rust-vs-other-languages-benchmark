using System;
using System.Collections.Generic;
namespace test01 {
    class test01 {
        static void Main(string[] args) {

            long total = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            long time1 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            for(int i=0;i<25000000;i++){
                map[i] = i;
            }
            long time2 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Console.WriteLine("HashMap put "+(time2-time1)+" ms");

            Console.ReadKey();

            long time3 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            for(int i=0;i<25000000;i++){
                total += map[i];
            }
            long time4 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Console.WriteLine("total = "+total);
            Console.WriteLine("HashMap get "+(time4-time3)+" ms");
        }
    }
}

