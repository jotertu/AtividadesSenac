using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade12
{
    class Estagiario : Funcionario
    {
     public override void BonusSalario(double acrescimo)
        {
            Console.WriteLine($"Valor do acrescimo: {acrescimo * 0.20}");
        }    
    }
}
