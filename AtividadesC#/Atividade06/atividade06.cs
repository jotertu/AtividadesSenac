using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade06
{
    class Params
    {
        /*
         Crie um programa em C# que armazene em um array com os nomes de 5 Alunos da sua
         sala. Utilizando a estrutura de repetição foreach, o programa deve exibir na tela todos os
         nomes no console.       
         */
        
        public static void toPresent(params string[] Classe)
        {
            foreach (string alunos in Classe)
            {
                Console.WriteLine($"As marcas selecionadas foram: {alunos}");
            }
        }

        public static void toPresent()
        {
            toPresent("João", "Gabriel", "Adriano", "Gustavo", "Fernando");
        }
    }


}

