using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade07
{   /*
     *
     *Escreva um programa que solicite ao usuário que digite um número inteiro positivo.
      utilizando a estrutura de repetição do-while, o programa deve exibir na tela todos os números
      pares de 0 até o número digitado pelo usuário.
     *
     */
    class atividade07
    {
        public static void Main()
        {
            
            Console.WriteLine("Insira o valor máximo");
            int valor = int.Parse(Console.ReadLine());
            

            for (int i = 0; i <= valor; i++)
            {
                Console.WriteLine(i);
                
                if(i % 2 == 0 )
                {
                    i++;
                }

            }
        }

    }
}
