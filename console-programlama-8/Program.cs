using System;

namespace console_programlama_2
{
    class Program
    {
        static void Main(string[] args)
        {
// int sayac = int.Parse(Console.ReadLine());
            // for (int i= 1 ; i<= sayac ; i++)
            // {
            //     if (i%2==1)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            // int tekToplam =0;
            // int ciftToplam =0;
            // for (int i = 0; i <= 1000; i++)
            // {
            //     if (i%2==1)
            //      tekToplam+= i;
            //     else
            //     ciftToplam+=i;  
            // }   
            // Console.WriteLine("Tek Toplam"+ tekToplam);
            // Console.WriteLine("Çift Toplam"+ ciftToplam);
            // Break, Continue

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)//continue kullanılınca 4 ü atlayıp devam eder.
            {
                if (i==4)
                continue;
                Console.WriteLine(i); 
            }
                
           }
}
