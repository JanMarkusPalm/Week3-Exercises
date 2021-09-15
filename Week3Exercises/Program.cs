using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:
            //miinimum matemaatikas 85 punkti
            //miinimum keemias 90 punkti
            //miinimum bioloogias 95 punkti
            //programm küsib kasutajal sisestada tema eksami punktid ja otsustab kas kasutaja saab arstiks õppida


            Console.WriteLine("Palun sisestage oma punktid eksamitel.");
            Console.WriteLine("Punktid matemaatika eksamil");
            int tulemusM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Punktid keemia eksamil");
            int tulemusK = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Punktid bioloogia eksamil");
            int tulemusB = Convert.ToInt32(Console.ReadLine());

            if (tulemusM >= 85 && tulemusK >= 90 && tulemusB >= 95)
            {
                Console.WriteLine("tubli töö, saad sisseastuda");
            }
            
            else
            {
                Console.WriteLine("punktid liiga madalad");
            }
        }
    }
}
