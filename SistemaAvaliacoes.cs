using System;
using System.Linq;
using System.Linq.Expressions;

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
        nota1 = int.Parse(Console.ReadLine());
        Console.Write("Nota 2 :");
        nota2 = int.Parse(Console.ReadLine());
        Console.Write("Nota 3 :");
        nota3 = int.Parse(Console.ReadLine());
        Console.Write("Nota 4 :");
        nota4 = int.Parse(Console.ReadLine());

    }
}