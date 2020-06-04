using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
        	Aluno[] alunos = new Aluno[5];

        	var indiceAluno = 0;

            string opçãoUsuario = ObterOpcaoUsuario();

            while (opçãoUsuario.ToUpper() != "X")
            {
                switch (opçãoUsuario)
                {
                    case "1":
                        // TO DO:Adicionar aluno
                    	Console.WriteLine("Informe o nome do aluno:");
                    	Aluno aluno = new Aluno();
                    	aluno.Nome = Console.ReadLine();

                    	Console.WriteLine("Informe a nota do aluno");

                    	if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                    	{
                    		aluno.Nota = nota;
                    	}else{
                    		throw new ArgumentException("O valor da nota deve ser decimal !");
                    	}

                    	alunos [indiceAluno] = aluno;

                    	indiceAluno++;
                        break;
                    case "2":
                        //TO DO: Listar alunos
                    foreach (var a in alunos) 
                    {
                    	if(!string.IsNullOrEmpty(a.Nome))
                    	{
                    	Console.WriteLine($"Alunos:{a.Nome} - NOTA: {a.Nota}");
                    	}
                    }
                        break;
                    case "3":
                        //TO DO: Calcular média geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opçãoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos:");
            Console.WriteLine("3 - Calcular média alunos");
            Console.WriteLine();
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opçãoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opçãoUsuario;
        }
    }
}
