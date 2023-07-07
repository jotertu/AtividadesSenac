using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade02
{
    class atividade03
    {
        /*
         * - Leia 2 valores reais N1 e N2, que correspondem a 2 notas de um aluno. A seguir, calcule a
            média do aluno, sabendo que a nota N1 tem peso 1 e a nota N2 tem peso 2. Assumindo que
            cada nota pode ir de 0 até 10.0
        */

        public static void main()
        {

            double n1, n2, media;
           

            Console.WriteLine("Insira a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine($"A média obtida foi de: {media}");

            if (media < 4.0)
            {
                Console.WriteLine("Aluno reprovado");
            }
            else if ((media >= 4.0) && (media <= 7.0))
            {
                Console.WriteLine("O aluno se encontra de exame");
            }

            else 
            {
                Console.WriteLine("Aluno aprovado");
            }



        }
    }
}
