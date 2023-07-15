using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade11
{
    abstract class ValidandoAluno
    {
        //Criando método obrigatório

        public abstract void ValidandoIdade(int idade);

    }

    class TesteValidacao : ValidandoAluno
    {
        public override void ValidandoIdade(int idade)
        {
            if (idade >= 16)
            {
                Console.WriteLine($"Aluno pode fazer o curso!");
            }
            else
            {
                Console.WriteLine($"Aluno Não pode fazer o curso!");

            }
        }
    }

    class ObjAluno
    {
        public static void Main()
        {
            TesteValidacao GabrielB = new TesteValidacao();
            GabrielB.ValidandoIdade(70);
            Console.WriteLine("------");

            TesteValidacao Jonatha = new TesteValidacao();
            Jonatha.ValidandoIdade(13);
        }
    }
}
