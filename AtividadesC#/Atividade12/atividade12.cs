using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade12
{
    public abstract class Funcionario
    {

        protected string Nome;
        protected double SalarioBase;
        
        protected void CalcularSalario()
        {
            Console.WriteLine($"Funcionario: {Nome}");
            Console.WriteLine($"Salário {SalarioBase}");
        }

        public virtual void BonusSalario(double acrescimo)
        {
            Console.WriteLine($"Valor do acrescimo: {acrescimo * 0.10}");
        }
      
    }


    class HerancaFuncionario : Funcionario
    {

        protected double ModSalario;
        public HerancaFuncionario (string nome, double salariobase, double modsalario)
        {
            Nome = nome;
            SalarioBase = salariobase;
            ModSalario = modsalario;

            CalcularSalario();
        }
        public void MensagemFuncionario()
        {
            Console.WriteLine($"Modalidade curso: {ModSalario}");
        }


    }


}
