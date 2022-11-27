using System;

namespace Lab1ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
               descrescatoare */

            Console.WriteLine("Introduceti numarul x ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul y ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul z ");
            int z = int.Parse(Console.ReadLine());

            if (x<y && y<z) Console.WriteLine(z + " " + y + " " + x);


            if(x>y && y<z)
            {
                if (x < z)
                {
                    Console.WriteLine(z + " " + x + " " + y);
                }
                else Console.WriteLine(x + " " + z + " " + y);
            }


            if(x>y && y>z)  Console.WriteLine(x + " " + y + " " + z);
           

            if(x<y && y>z)
            {
                if (x < z)
                {
                    Console.WriteLine(y + " " + z + " " + x);
                }
                else Console.WriteLine(y + " " + x + " " + z);
            }


            if (x == y && y == z)  Console.WriteLine(x+" "+y+" " + z);


            if (x == y)
            {
                if (x < z) Console.WriteLine(z + " " + x + " " + y);
                else Console.WriteLine(x + " " + y + " " + z);
            }
            

            if(y==z)
            {
                if (x < y) Console.WriteLine(y + " " + z + " " + x);
                else Console.WriteLine(x + " " + y + " " + z);
            }

            if(x==z)
            {
                if (y < z) Console.WriteLine(z + " " + x + " " + y);
               
            }
        }
    }
}
