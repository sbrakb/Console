using System;

namespace console_programlama_2
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Lütfen Gidilecek Sayıyı giriniz !");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam =0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayac);

            // a dan z ye yazdır 
            char character ='a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine("******Foreach******");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
                
            }
        }
    }
}
