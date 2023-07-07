using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade04
{
    class atividade04
    {

        /*
        Faça um programa conferir a idade. Se a idade for menor do que 18 anos, exiba uma
        mensagem informando que o usuário é não pode dirigir de idade. Se a idade for igual ou maior
        do que 18 anos e menor do que 60 anos, exiba uma mensagem informando que o usuário é
        adulto. Se a idade for igual ou maior do que 60 anos, exiba uma mensagem informando que o
        usuário é idoso.
         
         */

        public static void main()
        {

            Console.WriteLine("Boa tarde, para realizar o teste devemos verificar se o usuário é maior de idade");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Insira a sua idade ");
            uint idade = uint.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine($"O usuario é menor e possui {idade} anos, não foi possibilitado de tirar a carteira");
            }
            else if (idade >= 60) 
            {
                Console.WriteLine($"O usuario possui mais de {idade} anos, sendo assim, considerado idoso.");
            }
            else
            {
                Console.WriteLine($"O usuario é maior e possui {idade} anos, pode emitir a carteira com sucesso!");
                
            }


        }
    }
}
