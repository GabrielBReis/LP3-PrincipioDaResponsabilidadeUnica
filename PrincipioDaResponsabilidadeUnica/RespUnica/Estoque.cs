using System;

namespace RespUnica
{
    class Estoque
    {
        private Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();

        public void AdicionarProduto(string nome, double preco, int quantidadeEmEstoque)
        {
            if (!produtos.ContainsKey(nome))
            {
                produtos[nome] = new Produto(nome, preco, quantidadeEmEstoque);
            }
            else
            {
                produtos[nome].Estoque += quantidadeEmEstoque;
            }
        }

        public void RemoverProduto(string nome, int quantidade)
        {
            if (produtos.ContainsKey(nome) && produtos[nome].Estoque >= quantidade)
            {
                produtos[nome].Estoque -= quantidade;
            }
            else
            {
                Console.WriteLine("Estoque insuficiente");
            }
        }

        public double ObterPrecoProduto(string nome)
        {
            if (produtos.ContainsKey(nome))
            {
                return produtos[nome].Preco;
            }
            return 0.0;
        }
    }
}