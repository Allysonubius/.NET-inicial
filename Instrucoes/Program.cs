using System;


namespace Instrucoes {
    class Program {

        static void Declaracoes () {
            //Inteiros
            int a;
            int b = 2, c = 3;
            //Constantes inteiro
            const int d = 4;
            //Variaveis
            a = 1;
            //Impressão da soma
            Console.WriteLine (a + b + c + d);
        }
        static void InstrucoesIF (string[] args) {
            //Se ele passar pelo if e não houver argumento ele fazerá a impressão "Nenhum argumento"
            if (args.Length == 0) {
                Console.WriteLine ("Nenhum argumento");
                //Se ele passar pelo else if e houver um 1 argumento ele fazerá a impressão de "Um argumento"
            } else if (args.Length == 1) {
                Console.WriteLine ("Um argumento");
                //Agora se ele passar pelo else e houver mais de um argumento ele fazerá a impressão de "$quantos ? argumentos"
            } else {
                Console.WriteLine ($"{args.Length} argumentos");
            }
        }
        static void InstrucoesSwitch (string[] args) {
            //Criado um inteiro para ser o nosso valor neste numero de  argumentos
            int numeroArgumentos = args.Length;
            switch (numeroArgumentos){
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                    //Pare aqui se não haver argumentos
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                    //Pare aqui se houver um argumento
                default:
                    Console.WriteLine($"{numeroArgumentos} argumentos");
                    break;
                    //Será mostrado quantos argumentos existem
            }
        }
        static void InstrucoesWhile (string[] args) {
            //inteiro de uma variavel
            int i = 0;
            //while estrutura de repetição
            while (i < args.Length) {
                //Impressão
                Console.WriteLine (args[i]);
                //incremento
                i++;
            }
        }
        static void  InstrucoesDo(string []args){
            //Declarado um variavel do tipo string "TEXTO"
            string texto;
            do{//REadLine o usuario colocara um valor e o texto vai guardar na memoria 
                texto = Console.ReadLine();
                //Impessão da string texto 
                Console.WriteLine(texto);
                //aqui ele verifica se e verdadeiro ou falso !
            } while (!String.IsNullOrEmpty(texto));
            // ! o ponto de interrogação e a negativa da variavel
        }
        static void  InstrucoesFor(string[] args){
         //Declarando i = 0 , sendo que i e menor que o numero de argumentos incrementado
            for (int i = 0; i < args.Length;i++){
               //Impressão do numero de argumentos 
               Console.WriteLine(args[i]);
            }

        }
        static void InstrucoesForeach(string[] args){
         //Estamos dizendo que a variavel item para o argumento
            foreach (string s in args) {
               //Impressão do item do argumento
               Console.WriteLine(s);
            }
        }
        static void InstrucoesBreak(string[] args){
         //Colocamos while com a condição sendo verdadeira
            while (true) {
               string s =Console.ReadLine();
               //Ele fazera a validação enviada pelo usuario na memória
               if(string.IsNullOrEmpty(s))
                  break;
                  //Impressão do item S
                  Console.WriteLine(s);
            }
        }
        static void InstrucoesContinue(string []args){
         //Declaramos inteiro sendo qu= 0 , sendo que i e menor que o numero de argumentos incrementado
            for(int i = 0; i < args.Length; i ++){
               //sera feito a validação caso seja verdadeira ele continua
               if(args[i].StartsWith("/"))
               continue;
               //Impressão do numero de argumentos
               Console.WriteLine(args[i]);
            }
        }
        static void InstrucoesReturn(string[] args){
         //Declaramos um inteiro Somar sendo a e b
         int Somar(int a, int b){
            //retornamos a soma 
            return a + b;
         }
         //Impressão do comando Somar A + B = 
         Console.WriteLine(Somar("Soma: "+ 1,2));
         Console.WriteLine(Somar("Soma: "+ 3,4));
         Console.WriteLine(Somar("Soma: "+ 5,6));
        }
        static void InstrucoesTryCatchFinallyThrow(string[]args){
         double Dividir(double x , double y){
            if ( y == 0)
            throw new DivideByZeroException();
            return x/y;
         }try{
            if(args.Length ! = 2){
               throw new InvalidOperationException("Infrome 2 números");
            }
            double x = double.Parse(args[0]);
            double y = double.PArse(args[1]);
            Console.WriteLine(Dividir(x,y));
         }catch(InvalidOperationException e){
            Console.WriteLine(e.Message);
         }catch(Exception e){
            Console.WriteLine($"Erro genério:(e.Message)");
         }finally{
            Console.WriteLine("Ate breve");
         }
        }
        static void InstrucoesUsing(string[]args){
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt")){
               w.WriteLine("Line 1");
               w.WriteLine("Line 2");
               w.WriteLine("Line 3");
            }
        }
    }

}