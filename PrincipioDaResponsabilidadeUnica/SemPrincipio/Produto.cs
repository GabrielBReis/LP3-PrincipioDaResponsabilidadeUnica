using System;

namespace SemRespUnica
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

    }
}