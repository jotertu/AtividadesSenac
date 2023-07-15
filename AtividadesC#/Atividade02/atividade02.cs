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

        /**
         * Comentários
         * //1 a
            int a = 10;
            int b = 15;
            Console.WriteLine(a + b);
            //1 b
            string nome = "Paulo";
            Console.WriteLine(nome);
            //1 c
            bool carro = true;
            Console.WriteLine(carro);
            //1 d
            double valor = 3.1415;
            Console.WriteLine(valor);

            //2 a
            Console.WriteLine("Qual seu nome ? ");
            string nome1 = Console.ReadLine();
            //2 b
            Console.WriteLine("Qual a sua idade ? ");
            int idade = int.Parse(Console.ReadLine());
            //2 c
            Console.WriteLine("Qual bairro voçe mora ? ");
            string bairro = Console.ReadLine();
            //2 d
            Console.WriteLine("paulo".ToUpper());
            //2 e
            Console.WriteLine("Digite um numero");
            int num1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma dos numeros é" );
            Console.WriteLine(num1 + num2);

           
            //3 a
            string ph = "Paulo".Insert(5," alcantara");
            Console.WriteLine(ph);
        */
            

    }
}
