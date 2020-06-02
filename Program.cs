using System;

namespace _NET_inicial {
    class Program {
        static void Main (string[] args) {
            //Inteiro array (numero de vezes repetidos) = 5
            int numeroDeVezes = 5;
            //sendo o inteiro i o valor de 0, ele sera contado o numero de vezes menor que i sendo 0,1,2,3,4.
            for (int i = 0; i < numeroDeVezes; i++)
            //Estamos pedindo para ele mostrar o texto com o valor que fizemos acima.
                Console.WriteLine ($"Bem vindo ao mundo .NET {i}");
        }
    }
}