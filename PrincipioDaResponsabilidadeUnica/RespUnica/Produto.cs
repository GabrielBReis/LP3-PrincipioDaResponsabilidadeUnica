using System;

namespace RespUnica
{
    class Produto
    {
        public string Nome { get; }
        public double Preco { get; }
        public int Estoque { get; set; }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }

}