﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesC_.Atividade11
{
    class AlunoEnem : AlunoPadrao
    {
        public override void DescontoParcela(double parcela)
        {
            Console.WriteLine($"Valor do desconto: {parcela * 0.20}");
        }
    }
}
