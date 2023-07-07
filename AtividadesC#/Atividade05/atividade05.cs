using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade05
{
     class atividade05
    {


        /*
         Atividades relacionais: crie um programa que solicite ao usuário que digite a sua altura em
         metros e o seu peso em quilogramas. Em seguida, o programa deve calcular o índice de massa
         corporal (IMC) do usuário usando a fórmula IMC = peso / altura*2 e verificar se o IMC está
         dentro do intervalo saudável de 18,5 a 24,9. O programa deve imprimir na tela se o IMC está
         dentro do intervalo saudável ou não.
        
         */

        public static void main()
        {
            // calculo do imc
            Console.WriteLine("Insira o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o seu peso ( digite o valor utilizando '.' : ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a sua altura: digite o valor utilizando '.' ");
            double altura = double.Parse(Console.ReadLine());

            double imc = (peso / (altura * 2));


            if (imc < 18.5)
            {
                Console.WriteLine($"Peso abaixo da média {nome}");
            }

            else if ((imc <= 18.5) || (imc == 25))
            {
                Console.WriteLine($"Peso normal {nome}");
            }

            else if ((imc <= 25) || (imc == 30))
            {
                Console.WriteLine($"Sobre o peso {nome}");
            }

            else if ((imc < 30) || (imc == 35))
            {
                Console.WriteLine($"Grau de obesidade I {nome}");
            }

            else if ((imc < 35) || (imc == 40))
            {
                Console.WriteLine($"Grau de obesidade II {nome}");
            }

            else if (imc < 40)
            {
                Console.WriteLine($"Grau de obesidade III {nome}");
            }
        }
    }
}
