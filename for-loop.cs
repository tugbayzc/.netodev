﻿using System;

namespace donguler_for_loop // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lütfen bir sayı girin:");
            int sayac = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if(i%2 == 1)
                   Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int çiftToplam = 0;
            
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 0)
                   çiftToplam +=i;
                else
                   tekToplam +=i;
            }
            Console.WriteLine(tekToplam);
            Console.WriteLine(çiftToplam);

            //break,continue
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                   break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                   continue;
                Console.WriteLine(i);
            }
        }
    }
}