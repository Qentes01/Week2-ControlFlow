using System;

namespace PositiveNegetive
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada numbrid -10 kuni 10
            //programm kontrollib seda numbrit
            //kui number on positiivne,konsool kuvab"positive";
            //kui number on negativne,konsool kuvab "negative";
            // kui number on 0, siis konsool kuvab "null";

            Console.WriteLine("Sisestage number -10 kuni 10");

            int number = Convert.ToInt32(Console.ReadLine());

               if (number > 0)
              {
                Console.WriteLine("Positive");
              }

               else if (number < 0)
              {
                Console.WriteLine("Negative");
              }

             
               else
              {
                Console.WriteLine("null");
              }

        
        
        }   
    }
}
