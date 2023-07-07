using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AtividadesC_.Atividade01
{

    /* 1 - Utilizando os conceitos apresentados, pergunte via terminal.
        • Qual o nome do usuário;
        • Qual sua idade;
        • Bairro onde mora;
        • Passe o nome do usuário para todas as letras em maiúscula.
     * 
     * */
    class atividade01

    {
        public static void Main1()
            {
                Console.WriteLine("Insira o seu nome");
                string name = Console.ReadLine();

                Console.WriteLine("Insira o seu bairro");
                string neighborhood = Console.ReadLine();

                Console.WriteLine("Insira a sua idade");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine($"O nome do Usuario é: {name.ToUpper()}, a sua idade é de: {age} e ele mora no bairro {neighborhood}");

        }
    }

}
