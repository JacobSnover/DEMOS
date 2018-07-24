using System;

namespace DEMOS
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            int pyr = 9;
            string aster = "*";
            string white = " ";

            while (counter < 10)
            {
                for (int i = pyr; i >= 0; i--)
                {
                    Console.Write(white);

                }
                for (int j = -1; j < counter; j++)
                {

                    Console.Write(aster);
                    Console.Write(white);
                }
                Console.WriteLine();
                counter++;
                pyr--;
                System.Threading.Thread.Sleep(500);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }



        }
    }
}

