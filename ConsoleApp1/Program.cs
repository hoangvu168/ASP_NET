using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double Gio = 0;
            var loaico = LoaiCo.Vip;
            bool count = true;
            bool co = false;
            while (count)
            {
                Console.WriteLine("Vui long chon loai gay ban muon su dung !");
                Console.WriteLine("\t Gay thuong (30k/h) => Bam phim 1");
                Console.WriteLine("\t Gay Vip (50k/h) => Bam phim 2");
                Console.Write("\t\t Lua chon cua ban la :"); a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    loaico = LoaiCo.Thuong;
                }
                else if (a == 2)
                {
                    loaico = LoaiCo.Vip;
                }
                else
                {
                    continue;
                }
                Console.WriteLine("Ban co su dung them don co khong ?");
                Console.WriteLine("\t Co => Bam phim 1");
                Console.WriteLine("\t Khong => Bam phim 2");
                Console.Write("\t\t Lua chon cua ban la :"); b = int.Parse(Console.ReadLine());
                if (b == 1)
                {
                    co = true;
                }
                else if (b == 2)
                {
                    co = false;
                }
                else
                {
                    continue;
                }
            Console.Write("Ban choi trong bao lau (gio) :"); string input = Console.ReadLine();
            if (double.TryParse(input, out Gio) && Gio > 0)
            {
                count = false;
            }
            else
            {
                continue;
            }
        }
        double tongTien = Class1.TinhTongTien(loaico, Gio, co);
        Console.WriteLine($"\t Tong tien phai tra la: {tongTien} VND");
        Console.ReadLine();
        }
    }
}
