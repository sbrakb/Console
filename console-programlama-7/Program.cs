using System;

namespace console_programlama_2
{
    class Program
    {
        static void Main(string[] args)
        {
int month = DateTime.Now.Month;
            //expression
            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak");
                break;
                case 2:
                 Console.WriteLine("Şubat");
                break;
                case 3:
                 Console.WriteLine("Mart");
                break;
                case 12:
                Console.WriteLine("Aralık");
                break;
              default:
                Console.WriteLine("Yanlış Verii");
              break;

              // Mevsim
            
        
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("Kış Ayındasınız !");
                break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("İlkbahar Ayındasınız !");
                break;
                case 6:
                case 7:
                case 8:
                Console.WriteLine("Yaz Ayındasınız !");
                break;
                case 9:
                case 10:
                case 11:
                Console.WriteLine("Sonbahar Ayındasınız !");
                break;
                default:
                break;
                
                
           }
}
