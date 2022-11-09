using System;

namespace if_else{

    class Program{
        static void Main(string[] args){
            int saat = DateTime.Now.Hour;

            if(saat <=18 && saat >= 12{
                Console.WriteLine("İyi Günler!");
            }
            if(saat <=12 && saat >= 6{
                Console.WriteLine("Günaydın!");
            }
            if(saat <=23 && saat >= 18{
                Console.WriteLine("İyi Akşamlar");
            }
            if(saat <=23 && saat >= 6{
                Console.WriteLine("İyi Geceler");
            }
        }
    }
}
