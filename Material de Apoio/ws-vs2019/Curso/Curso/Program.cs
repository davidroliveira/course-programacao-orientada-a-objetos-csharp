using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //SByte x = 100;
            //Console.WriteLine(x);

            byte n1 = 255; //overflow
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //L écomendação pra mostrar que é long

            n1++;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

        }
    }
}
