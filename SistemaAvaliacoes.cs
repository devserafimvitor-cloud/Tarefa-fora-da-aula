using System;
using System.Linq;


class SistemaAvaliacoes
{
    static void Main()
    {
        //Aqui vai -uma mensagem de boas vindas para o usuario no sistema de avaliações de alunos....
        Console.WriteLine("Bem-vindo ao Sistema de Avaliações de Alunos!");

        int nota1, nota2, nota3, nota4;
        double media;
        string nome;
        string autenticacao;
        


        //Agora aqui vou perguntar o nome do aluno para o usuario....
        Console.WriteLine("Por favor digite o nome do aluno...");
        Console.Write("Nome :");
        nome = Console.ReadLine();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("O nome do aluno não pode ser vazio. Por favor,  tente novamente.");
            return;
        }else if (nome.Any(char.IsDigit))
        {
            Console.WriteLine("O nome do aluno não pode conter números. Por favor, tente novamente.");
            return;
        }
        else
        {
            Console.WriteLine($"Olá, {nome}! Vamos começar a avaliação das suas notas.");
        }

        //Agora aqui vou perguntar as 4 notas do aluno para o usuario....
        Console.WriteLine("Agora, porfavor digite as 4 notas do aluno");
        Console.Write("Nota 1 :");
        if(int.TryParse(Console.ReadLine(), out nota1))
        {
            if (nota1 < 0 || nota1 > 100)
            {
                Console.WriteLine("A nota deve ser entre 0 e 100. Por favor, tente novamente.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite uma nota válida para a Nota 1.");
            return;
        }

        //Aqui vou perguntar a nota 2
        Console.Write("Nota 2: ");
        if (int.TryParse(Console.ReadLine(), out nota2))
        {
            if (nota2 < 0 || nota2 > 100)
            {
                Console.WriteLine("A nota deve ser entre 0 e 100. Por favor, tente novamente.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite uma nota válida para a Nota 2.");
            return;
        }

        //Aqui vou perguntar a nota 3....
        Console.Write("Nota 3: ");
        if (int.TryParse(Console.ReadLine(), out nota3))
        {
            if (nota3 <0 || nota3 > 100)
            {
                Console.WriteLine("A nota deve ser entre 0 e 100. Por favor, tente novamente.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite uma nota válida para a nota 3.");
            return;
        }

        //Aqui vou perguntar a nota...
        Console.Write("Nota 4:");

        if(int.TryParse(Console.ReadLine(), out nota4))
        {
            if (nota4 < 0 || nota4 > 100)
            {
                Console.WriteLine("A nota deve ser entre 0 e 100. Por favor, tente novamente.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Por favor, digite uma nota válida para a Nota 4");
            return;
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        
       //Aqui vamos calcular a média das notas do aluno....

       media = (nota1 + nota2 + nota3 + nota4) / 4.0;
       string resultado = VerificarAprovacao(media, nota1, nota2, nota3, nota4);

       Console.Write($"Nome do aluno: {nome}\n Média: {media:F2}\n Situação: {resultado}");

       //Aqui vai ser as regras para o aluno ser aprovado ou reprovado....
    } 
    static string VerificarAprovacao(double media, int nota1, int nota2, int nota3, int nota4)
    {
    if (nota1 >= 70 && nota2 >= 70 && nota3 >= 70 && nota4 >= 70)
    {
        return "Aluno aprovado com destaque!";
    }
    else if (media >= 70)
    {
        return "Aluno aprovado com louvor!";
    }
    else if (media >= 60)
    {
        return "Aluno aprovado!";
    }
    else if (media >= 40)
    {
        return "Aluno em recuperação!";
    }
    else
    {
        return "Aluno reprovado!";
    }
   }
}