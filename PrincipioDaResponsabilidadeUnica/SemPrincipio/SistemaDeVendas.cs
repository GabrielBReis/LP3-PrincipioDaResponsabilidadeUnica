using System;

namespace SemRespUnica
{
    class SistemaDeVendas
    {
        private Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();
        private Dictionary<string, string> clientes = new Dictionary<string, string>();

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

        public void AdicionarCliente(string nome, string email)
        {
            clientes[nome] = email;
        }

        public double ObterPrecoProduto(string nome)
        {
            if (produtos.ContainsKey(nome))
            {
                return produtos[nome].Preco;
            }
            return 0.0;
        }

        public void ProcessarPagamento(string nomeCliente, double total)
        {
            if (clientes.ContainsKey(nomeCliente))
            {
                // Lógica para processar o pagamento aqui
                Console.WriteLine($"Pagamento de {total} processado para o cliente {nomeCliente} ({clientes[nomeCliente]})");
            }
        }
    }
}
