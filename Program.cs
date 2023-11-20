using System;
using System.Linq;

namespace algoritma_sorulari_odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new();

            islemler.EvenNumbers();

            // islemler.NumberMode();

            // islemler.WordReverse();

            // islemler.WordAndCharacter();

        }
    }
    class Islemler
    {
        public void EvenNumbers()
        {
            Console.Write("Lütfen sayı adedini giriniz: ");
            int n = int.Parse(Console.ReadLine()).CheckOrConvertToPoitive();
            int[] dizi = new int[n];

            // dizi = Console.ReadLine().TrimEnd().Split(" ").ToArray().Select(temp => Convert.ToInt32(temp)).ToArray();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i+1);
                dizi[i] = int.Parse(Console.ReadLine()).CheckOrConvertToPoitive();
            }

            foreach (var sayi in dizi)
            {
                if(sayi%2==0)
                    Console.Write(sayi + " ");
            }
        }
    
        public void NumberMode()
        {
            Console.Write("Lütfen sayı adedini giriniz: ");
            int n = int.Parse(Console.ReadLine()).CheckOrConvertToPoitive();

            Console.Write("Lütfen kontrol edilecek değeri giriniz: ");
            int m = int.Parse(Console.ReadLine()).CheckOrConvertToPoitive();

            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i+1);
                dizi[i] = int.Parse(Console.ReadLine()).CheckOrConvertToPoitive();
            }

            foreach (var sayi in dizi)
            {
                if(sayi%m==0)
                    Console.Write(sayi + " ");
            }
        }

        public void WordReverse()
        {
            Console.Write("Lütfen kelime adedini giriniz: ");
            int n = int.Parse(Console.ReadLine()).CheckOrConvertToPoitive();
            string[] dizi = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. kelimeyi giriniz: ", i+1);
                dizi[i] = Console.ReadLine();
            }

            Array.Reverse(dizi);

            foreach (var kelime in dizi)
            {
                Console.Write(kelime + " ");
            }

        }

        public void WordAndCharacter()
        {
            Console.Write("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            int harfSayisi=0;
            int kelimeSayisi=0;

            string[] dizi = cumle.TrimEnd().Split(" ");

            foreach (var kelime in dizi)
            {
                kelimeSayisi++;
                foreach (var harf in kelime)
                {
                    harfSayisi++;
                }
            }

            Console.WriteLine("Kelime Sayisi: " + kelimeSayisi);
            Console.WriteLine("Harf Sayisi: " + harfSayisi);

        }

    }

    public static class CustomExtension
    {
        public static int CheckOrConvertToPoitive(this int param)
        {
            while(true)
            {
                if(param > 0)
                    break;
                else
                {
                    Console.WriteLine("Sayı negatif !!!");
                    Console.Write("Lütfen pozitif bir sayı girin: ");
                    param = int.Parse(Console.ReadLine());
                }
            }
            return param;
        }
    }
}
