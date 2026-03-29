using System;
using System.Threading;

class VooSimples
{
    static void Main()
    {
        //alt = Altitude, vlc = velocidade...
        int alt;
        int vlc;
        string nomeDoAviao = "Azul3805";
        string resultado = "Você não esta autorizado para pouso por causa da sua altitude";
        string resultado2 = "Velocidade muito alto para pouso";

        //Primeiro vamos fazer uma mensagem de bom dia para o piloto do aviao....
        Console.WriteLine("Bom-dia võo Azul3805....");

        //Agora aqui vai perguntar para o piloto a altitude que ele está.
        Console.WriteLine("Voo Azul3805, Qual é a sua altitude de voo?");
        alt = int.Parse(Console.ReadLine());

        if (alt < 1000)
        {
            resultado = "Risco muito alto de colisão com montanhas. Suba para 1000 pes,  e continue aproximação";
        }

        if (alt > 1000)
        {
            resultado = "Altidude muito alto. desça para 1000 pes, e continue aproximação";
        }

        if(alt == 1000)
        {
            resultado = "Altidude certa para pouso";
            
        }

        //Agora aqui  vai perguntar a velocidade do avião......
        Console.WriteLine("Voo {0}, Qual a sua velocidade de voo?",nomeDoAviao);
        vlc = int.Parse(Console.ReadLine());

        if(vlc < 170)
        {
            resultado2 = "Velocidade muito baixa para pouso.... Aumente sua velocidade para 190, e esta autorizado para pouso....";
            
        }

        if(vlc > 220)
        {
            resultado2 = "Sua velocidade esta muito alta para pouso.... Diminua para 200, e esta autorizado para pouso";
        }

        if(vlc >= 170 && vlc <=220)
        {
           resultado2 = "Matenha a velocidade para pouso, Pouso autorizado";
           
        }

        //Console.WriteLine("Voo {0}, {1}", nomeDoAviao, resultado2, resultado2);
        Console.WriteLine("Voo {0}, \n{1},\n{2} ", nomeDoAviao,resultado,resultado2);
        Thread.Sleep(3000);
        //Aqui esta lista de informaçoes do pouso do aviao...
        Console.WriteLine("Velocida: {0}\nAltitude:{1}\nNumero do voo:{2}",vlc,alt, nomeDoAviao);


    }
}