using System;
using System.Threading;

class SistemaDeIdade
{
    static void Main()
    {
        int idade;
        string nome;
        string resultado;

        Console.WriteLine("Oi, BOM DIA! \nEU GOSTARIA DE SABER O SEU NOME!");
        nome = Console.ReadLine();

        Console.WriteLine("Agora eu gostaria de a saber sua idade.");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            resultado = "A pessoa esta liberada para entra";
        }else if(idade >=16 && idade < 18)
        {
            resultado = "A pessoa esta liberada para entra com restrições!";
        }else if(idade >=12 && idade < 16)
        {
            resultado = "Entrada somente com os pais.";
        }else
        {
            resultado = "Entrada Proibida! idade insuficiente.";
        }

        Console.WriteLine("Nome: {0} \nIdade: {1} \nAutorização: {2}",nome,idade,resultado);


    }
}