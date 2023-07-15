using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade11
{
    class AlunoPadrao
    {
        //Atributos 
        protected string Nome;
        protected string Curso;
        protected int Ra;
        //método Protegido
        protected void AcessandoValores()
        {
            Console.WriteLine($"Aluno: {Nome}");
            Console.WriteLine($"Matricula {Curso}");
            Console.WriteLine($"R.A do Aluno {Ra}");
        }
        public virtual void DescontoParcela(double parcela)
        {
            Console.WriteLine($"Valor do desconto: {parcela * 0.05}");
        }
    }

    class HerenacaAluno : AlunoPadrao
    {
        //Atributos
        protected string ModCurso;
        //Construtor
        public HerenacaAluno(string nome, string curso, int ra, string modcurso)
        {
            Nome = nome;
            Curso = curso;
            Ra = ra;
            ModCurso = modcurso;

            AcessandoValores();
        }
        public void MensagemAluno()
        {
            Console.WriteLine($"Modalidade Curso: {ModCurso}");
        }

    }

    class TesteHeranca
    {
        public static void main()
        {
            HerenacaAluno Aluno01 = new HerenacaAluno("Ermeson", "JS", 2023, "A");
            Aluno01.MensagemAluno();
        }
    }

    internal class ObjetoPolimorfismo
    {
        public static void Main()
        {
            AlunoProUni Aluno01 = new AlunoProUni();
            Aluno01.DescontoParcela(1000);
            Console.WriteLine("----------");

            AlunoEnem Aluno02 = new AlunoEnem();
            Aluno01.DescontoParcela(1000);
            Console.WriteLine("----------");

            AlunoPadrao Aluno03 = new AlunoPadrao();
            Aluno01.DescontoParcela(1000);
            Console.WriteLine("----------");
        }
    }
}

