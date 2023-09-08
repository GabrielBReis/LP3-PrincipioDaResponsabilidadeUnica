using System;

namespace SemRespUnica
{
    class SistemaDeVendas
    {
        private List<Produto> produtos = new List<Produto>();
        private List<Cliente> clientes = new List<Cliente>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto, int quantidade)
        {
            var produtoNoEstoque = produtos.Find(p => p.Nome == produto.Nome);
            if (produtoNoEstoque != null && produtoNoEstoque.Estoque >= quantidade)
            {
                produtoNoEstoque.Estoque -= quantidade;
            }
            else
            {
                Console.WriteLine("Estoque insuficiente");
            }
        }

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public double ObterPrecoProduto(string nome)
        {
            var produto = produtos.Find(p => p.Nome == nome);
            return produto != null ? produto.Preco : 0.0;
        }

        public void ProcessarPagamento(Cliente cliente, double total)
        {
            if (clientes.Contains(cliente))
            {
                // Lógica para processar o pagamento aqui
                Console.WriteLine($"Pagamento de {total} processado para o cliente {cliente.Nome} ({cliente.Email})");
            }
        }
    }
}
