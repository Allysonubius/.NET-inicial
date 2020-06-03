using System;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {

            var s = new Pilha();
            s.Empilha("Cliente " + 1);
            s.Empilha("Cliente " + 2);
            s.Empilha("Cliente " + 3);

            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}