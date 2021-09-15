using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mitu kraadi õues on
            //kui õues on rohkem kui 35 kraadi, programm kuvab "päris krdi palav on"
            //kui õues on 30 kuni 35 kraadi, programm kuvab "kuum"
            //kui õues on 20 kuni 30 kraadi, programm kuvab "nice"
            //kui õues on 10 kuni 20 kraadi, programm kuvab "suht jahe"
            //kui õues on 0 kuni 10 kraadi, programm kuvab "cold"
            //kui õues on alla 0 kraadi, programm kuvab "freezing my nuts off"

            
             Console.WriteLine("Palun sisestage mitu kraadi on õues.");
            //case var _ when kraad < 0:
            //case var _  when (kraad > 0 && temp < 10):
            int kraad = Convert.ToInt32(Console.ReadLine());
           
            switch(kraad)
            {
                case 35: Console.WriteLine("kuum"); break;
                case 34: Console.WriteLine("kuum"); break;
                case 33: Console.WriteLine("kuum"); break;
                case 32: Console.WriteLine("kuum"); break;
                case 31: Console.WriteLine("kuum"); break;
                case 30: Console.WriteLine("kuum"); break;

                case 29: Console.WriteLine("nice"); break;
                case 28: Console.WriteLine("nice"); break;
                case 27: Console.WriteLine("nice"); break;
                case 26: Console.WriteLine("nice"); break;
                case 25: Console.WriteLine("nice"); break;
                case 24: Console.WriteLine("nice"); break;
                case 23: Console.WriteLine("nice"); break;
                case 22: Console.WriteLine("nice"); break;
                case 21: Console.WriteLine("nice"); break;
                case 20: Console.WriteLine("nice"); break;

                case 19: Console.WriteLine("suht jahe"); break;
                case 18: Console.WriteLine("suht jahe"); break;
                case 17: Console.WriteLine("suht jahe"); break;
                case 16: Console.WriteLine("suht jahe"); break;
                case 15: Console.WriteLine("suht jahe"); break;
                case 14: Console.WriteLine("suht jahe"); break;
                case 13: Console.WriteLine("suht jahe"); break;
                case 12: Console.WriteLine("suht jahe"); break;
                case 11: Console.WriteLine("suht jahe"); break;
                case 10: Console.WriteLine("suht jahe"); break;

                case 9: Console.WriteLine("cold"); break;
                case 8: Console.WriteLine("cold"); break;
                case 7: Console.WriteLine("cold"); break;
                case 6: Console.WriteLine("cold"); break;
                case 5: Console.WriteLine("cold"); break;
                case 4: Console.WriteLine("cold"); break;
                case 3: Console.WriteLine("cold"); break;
                case 2: Console.WriteLine("cold"); break;
                case 1: Console.WriteLine("cold"); break;
                case 0: Console.WriteLine("cold"); break;

                default:Console.WriteLine("õues on kas liiga külm või liiga soe"); break;
            }
            
            
            /*
            Console.WriteLine("Palun sisestage mitu kraadi on õues.");
            int kraad = Convert.ToInt32(Console.ReadLine());
            
            if (kraad>=35)
            {
                Console.WriteLine("õues on surmavalt palav");
            }
            else if (kraad >= 30 && kraad <35)
            {
                Console.WriteLine("ma sulan");
            }
            else if (kraad >= 20 && kraad < 30)
            {
                Console.WriteLine("nice");
            }
            else if (kraad >= 10 && kraad < 20)
            {
                Console.WriteLine("suht jahe");
            }
            else if (kraad >= 0 && kraad < 10)
            {
                Console.WriteLine("cold");
            }
            else if (kraad < 0)
            {
                Console.WriteLine("freezing my nuts off");
            }
            */
        }
    }
}
