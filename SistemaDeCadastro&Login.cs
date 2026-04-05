using System;
using System.Threading;

class SistemaDecadastroLogin
{
    static string[] nomes = new string[100];
    static string[] emails = new string[100];
    static string[] senhas = new string[100];
    static int totalUsuarios = 0;

    static void Main()
    {
        //Aqui vou mostrar uma mensagem de boas vindas para o usuario....
        Console.WriteLine("=========================================");
        Console.WriteLine("Bem-vindo ao Sistema de Cadastro e Login");
        Console.WriteLine("=========================================");
        Thread.Sleep(3000); // Pausa por 3 segundos para o usuario ler a mensagem de boas vindas
        Menu();

    }

    static void Menu()
    {
        Console.WriteLine("====== Sistema de Cadastro e Login ======");
        Console.WriteLine("1. Cadastrar Usuário");
        Console.WriteLine("2. Fazer Login");
        Console.WriteLine("3. Listar Usuários cadastrados");
        Console.WriteLine("4. Sair do Sistema");
        Console.WriteLine("=========================================");
        Console.WriteLine("Digite a opção desejada!");
        Console.WriteLine("=========================================");

        Console.WriteLine("Qual opção que você deseja? ");
        int opção = int.Parse(Console.ReadLine());

        if (opção == 1)
        {
            CadastrarUsuario();
        }
        else if(opção == 2)
        {
            LoginUsuario();
        }
         else if(opção == 3)
        {
            ListaDeUsuarios();
        }
        else if (opção == 4)
        {
            SairDoSistema();
        }
        else
        {
            Console.WriteLine("Opção invalida! Por favor, escolha uma opção válida.");
            for (int i = 3; i > 0; i--)
            {
                Console.Write($"Tente novamente em:{i}", i);
                Thread.Sleep(1000); // Pausa por 3 segundos para o usuario ler a mensagem de opção invalida....
                Console.Clear();
            }
            Console.Clear(); // Aqui vai apagar a tela para o usuario escolher uma opção valida....
            Menu(); //Chamando o menu novamente para o usuario escolher uma opção valida.....
        }
    }

    static void CadastrarUsuario()
    {
        Console.Clear(); // Limpa a tela para o usuario
        if (totalUsuarios >= nomes.Length)
        {
            Console.WriteLine("Limite de usuários atingido! Não é possivel cadastrar mais usuários.");
            Thread.Sleep(2000);
            return; // sai do metado de cadrasto de usuario...
        }
        string nome, email, senha;

        do
        {
            Console.Write("Digite o nome do usuário: ");
            nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("O nome não pode ser vazio! Por favor, digite um nome válido.");
            }
        } while(string.IsNullOrWhiteSpace(nome));
        do
        {
            Console.Write("Digite o email do usuario: ");
            email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("O email não pode ser vazio! Por favor, digite um email válido.");
            }
        
            bool emailExistente = false;
            for (int i = 0; i < totalUsuarios; i++)
            {
        
             if (emails[i] == email)
             {
                emailExistente = true;
                break;
             }
            }
        
            if (emailExistente)
            {
        
            Console.WriteLine("Esse email já está cadastrado! Por favor, digite um email diferente.");
            email = "";
            }

        } while (string.IsNullOrWhiteSpace(email));
        do
        {
            Console.Write("Digite a senha do usuário: ");
            senha = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(senha))
            {
                Console.WriteLine("A senha não pode ser vazia! Por favor, Digite uma senha valida.");
            }
        }
        while(string.IsNullOrWhiteSpace(senha));

        nomes[totalUsuarios] = nome;
        emails[totalUsuarios] = email;
        senhas[totalUsuarios] = senha;

        totalUsuarios++; // próximo usuário

        Console.WriteLine("Usuário cadastrado com sucesso!");
        Thread.Sleep(2000);
        Menu();


    }
    static void LoginUsuario()
    {
        Console.Clear();

        Console.Write("Digite seu nome: ");
        string nomeDigitado = Console.ReadLine();
        Console.Write("Digite seu email: ");
        string emailDigitado = Console.ReadLine();
        Console.Write("Digite sua senha: ");
        string senhaDigitada = Console.ReadLine();

        bool usuarioEncontrado = false;

        for (int i = 0; i < totalUsuarios; i++)
        {
            if (nomes[i] == nomeDigitado && emails[i] == emailDigitado && senhas[i] == senhaDigitada)
            {
                usuarioEncontrado = true;
                break;
            }
        }

        if (usuarioEncontrado)
            Console.WriteLine("Login realizado com sucesso!");
        else
            Console.WriteLine("Nome, email ou senha incorretos.");

        Thread.Sleep(2000);
    }

     static void ListaDeUsuarios()
    {
          Console.Clear();
        if (totalUsuarios == 0)
        {
            Console.WriteLine("Nenhum usuário cadastrado!");
        }
        else
        {
            Console.WriteLine("===== Usuários cadastrados =====");
            for (int i = 0; i < totalUsuarios; i++)
            {
                Console.WriteLine($"{i + 1} - Nome: {nomes[i]}, Email: {emails[i]}");
            }
            Console.WriteLine("===============================");
        }

        Console.WriteLine("Pressione Enter para voltar ao menu...");
        Console.ReadLine();
        Menu();
    }

    static void SairDoSistema()
    {
        Console.Clear();
        Console.WriteLine("Saindo do sistema...");
        Thread.Sleep(1500);
        Environment.Exit(0);
    }
}