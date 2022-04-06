using System;

namespace CalculateSumInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programma generiruet 10 slucainih cisel( ot 1 do 10) vivodit ih znacenie na ekran
            //programma podshityvaet summu etih cisel i vivodit summu na ekran

            Random rnd = new Random();

            int myRandom = 0;
            int sum = 0;




            for (int i = 1; i < 11; i++)
            {
                myRandom = rnd.Next(1, 11);
              
                sum = sum + myRandom;
                Console.WriteLine($"{i} Random nr: {myRandom}");
            }

            Console.WriteLine(myRandom);
            Console.WriteLine($"Summa = {sum}", sum);

            




        }
    }
}
