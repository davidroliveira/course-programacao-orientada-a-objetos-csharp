using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValotTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
    }
}
