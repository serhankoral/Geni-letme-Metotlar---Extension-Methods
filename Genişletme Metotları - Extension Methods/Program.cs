using System;

namespace Genişletme_Metotları___Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extention var olan parametrelere yenisi eklemek için kullanılır
            //Class static olarak yapılmalı
            string metin = "Serhan Koral";
            metin.yaz();
            metin.yaz(15);
            
        }
    }
    static class StringGenisletme
    {
        public static void yaz(this string metin)
        {
            Console.WriteLine(metin);
        }
        public static void yaz(this string metin,int sayi)
        {
            Console.WriteLine(metin+" "+sayi.ToString());
        }        
    }
}
