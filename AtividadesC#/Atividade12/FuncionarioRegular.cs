using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade12
{
    class FuncionarioRegular : Funcionario
    {
        public virtual void BonusSalario(double acrescimo)
        {
            Console.WriteLine($"Valor do acrescimo: {acrescimo * 0.20}");
        }    
    }
}
