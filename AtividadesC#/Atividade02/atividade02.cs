using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.atividade02
{
    class atividade02
    {

        /*
         * Crie um programa que solicite ao usuário que digite um número inteiro e verifique se esse
         * número é positivo. Em seguida, o programa deve imprimir na tela se o número é positivo ou não.
         */
        public static void main()
        {

            Console.WriteLine("Insira o valor: ");
            uint number = uint.Parse(Console.ReadLine());


            if (number < 3)
            {
                Console.WriteLine("Numero negativo, tente novamente");
            }
            else
            { 
                Console.WriteLine($"Numero positivo:{number}");
            }

        }
            

    }
}
