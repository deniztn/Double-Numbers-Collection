using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Numbers_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("1. sayıyı giriniz:");
            int s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int s2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("3. sayıyı giriniz:");
            int s3 = Convert.ToInt16(Console.ReadLine());
            if (s1 % 2 == 0)
                sum = sum + s1;
            else if (s2 % 2 == 0)
                sum = sum + s2;
            else if (s3 % 2 == 0)
                sum = sum + s3;
            else
                Console.Write("hata");
            Console.Write("toplam:" + sum);
            Console.ReadKey();
        }
    }
}
