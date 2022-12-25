﻿using System;

namespace console_programlama_2
{
    class Program
    {
        static void Main(string[] args)
        {
             // implicit Conversion (bilinçsiz dönüşüm)
            Console.WriteLine("implicit Conversion");
            byte a = 5;
            sbyte b=30;
            short c= 10 ;

            int d = a+b+c;
            Console.WriteLine("d:" + d);
            long h = d;
            Console.WriteLine("h:" + h);
            float i = h;
            Console.WriteLine("i:" + i);

            string e = "Ömür";
            char f ='k';
            object g = e+f+d;
            Console.WriteLine("g:" + g);

            // explicit Conversion (bilinçli Dönüşüm)
            Console.WriteLine("explicit Conversion");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            int z = 100;
            byte t =(byte)z;
            Console.WriteLine("t:"+t);

            float w = 10.3f;
            byte v= (byte)w;
            Console.WriteLine("v:"+v);

            //ToString Methodu
            Console.WriteLine("ToString Methodu");
            int xx = 6;
            string yy= xx.ToString();
            Console.WriteLine("yy:"+yy);

            string zz = 12.4f.ToString();
            Console.WriteLine("zz:"+zz);

            // System.convert
             Console.WriteLine("System.convert");
             string s1 = "10",s2 ="20";
             int sayi1,sayi2 ;
             int toplam;
             sayi1= Convert.ToInt32(s1);
             sayi2=Convert.ToInt32(s2);
             toplam = sayi1 + sayi2;
             Console.WriteLine("toplam:"+ toplam);


             //Parse 
             Console.WriteLine("Parse");
                 ParseMethod();

        }
        public static void ParseMethod()
        {
            string metin1= "10";
            string metin2="10.25";
            int rakam1;
            double double1;
            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);
            Console.WriteLine("Rakam 1:"+metin1);
            Console.WriteLine("Rakam 2:"+metin2);



        }
    }
}
