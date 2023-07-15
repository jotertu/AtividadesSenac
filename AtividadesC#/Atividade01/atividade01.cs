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

            /*
            Console.WriteLine("Qual a marca do carro ? ");
            string marca = Console.ReadLine();
            Console.WriteLine("Qual o modelo do carro ?");
            string modelo = Console.ReadLine();
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine($"");

            Console.WriteLine("Qual seu nome ? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade ? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu peso ? ");
            int peso = int.Parse(Console.ReadLine());
            */
        }
    }

    /*
    Comentários
    {   
        /*Console.WriteLine("hello world");
            //declarando variaveis
           
            var nome = "paulo";
            Console.WriteLine(nome);
            double sal = 4500.58;
            Console.WriteLine(sal);
            string olaMundo = "ola, mundo";"
            Console.WriteLine(olaMundo);
            int idade = 29;
            Console.WriteLine(idade);
            bool praia = false;
            Console.WriteLine(praia);
            
            byte num1 = byte.MaxValue;
            byte num2 = byte.MinValue;

            int
            double
            string
            bool prova = true; // false

            /*Console.WriteLine("O valor maximo " + num1 + " valor minimo " + num2);
            Console.WriteLine("O valor maximo: {0}", num1);
            Console.WriteLine($"O valor maximo: {num1}");

            string nome = "Paulo";
            int idade = 29;
            double nota = 10;
            Console.WriteLine("O aluno {0} tem {1} anos de idade e tirou {2} na prova" ,nome ,idade ,nota);
            Console.WriteLine($"O aluno {nome} tem {idade} anos de idade e tirou {nota} na prova");

            string marca = "nissan".ToUpper();//ToUpper = deixa tudo maiusculo
            string carro = "gtr".ToLower();//ToLower = deixa tudo minusculo
            int potencia = 552;
            double ano = 2022;

            string marca = "nissan".ToUpper();//ToUpper = deixa tudo maiusculo
            string carro = "gtr".Insert(3, " R35");
            int potencia = 552;
            double ano = 2022;

       }
            */


}
