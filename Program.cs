using System;

namespace console_prog
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz!!");
            
            Console.WriteLine("*** for loop ***");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if(i%2==1)
                Console.WriteLine(i);
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içnlerinde toplamlarını ekrana yazdır.
            int tekToplam=0;
            int çiftToplam=0;
            for (int i = 1; i <= 1000; i++)
            {
               if(i%2==1)
                    tekToplam+=i; // tektoplam=tektoplam +i;
               else
                    çiftToplam+=i; // tektoplam=tektoplam +i;
            }

            Console.WriteLine("Tek Toplam:"+tekToplam);
            Console.WriteLine("Çift Toplam:"+çiftToplam);

            // break, continue
                Console.WriteLine("**** break ****");
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }
                Console.WriteLine("**** Continue ****");
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }
            

            Console.ReadKey();
        }
   }   
}