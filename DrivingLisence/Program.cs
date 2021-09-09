using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaatat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutjad, kas ta on piisavalt vana,
            //et juhiluba saada (tingimuseks 18 aastat vana)

            Console.WriteLine("Sisestage oma sünniaasta");
            
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int Age = 2021 - YearOfBirth;

            if (Age >= 18)
            {
                Console.WriteLine("Oled piisavalt vana, et teha juhilube.");
            }
            else 
            {
                Console.WriteLine("Oled liiga noor,tingimuseks on 18+.");
            }
            
            Console.WriteLine("Kena päeva.");

            

        }
    }
}
