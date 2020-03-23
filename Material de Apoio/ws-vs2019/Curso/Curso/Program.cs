using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //SByte x = 100;
            //Console.WriteLine(x);
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041'; //codigo unicode

            byte n1 = 255; //overflow
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //L écomendação pra mostrar que é long
            float n5 = 4.5f; //float
            double n6 = 4.5;
            string nome = "Maria Green"; //string é com aspas duplas, char é com aspas simples
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            n1++;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(decimal.MaxValue);

        }
    }
}
