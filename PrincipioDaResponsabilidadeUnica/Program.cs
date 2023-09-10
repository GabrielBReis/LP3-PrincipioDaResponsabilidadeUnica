using System;
using RespUnica;

    class Program
    {
        static void Main(string[] args)
    {
        
        Cliente cliente1 = new Cliente("Fulano","Fuladoemail@gmail.com");
       // Produto jbl = new Produto("JBL go 3", 256.0, 900);
        Estoque estoque = new Estoque();
        Pagamento pagamento = new Pagamento();

        estoque.AdicionarProduto("Cafe premium", 10.3, 50);
        estoque.AdicionarProduto("Jbl go 3", 256.5, 100);
       
        double precoProduto1 = estoque.ObterPrecoProduto("Cafe premium");
        double precoProduto2 = estoque.ObterPrecoProduto("Jbl go 3");

        //Fulano checa o preço 
        Console.WriteLine($"Preço do Cafe premium: {precoProduto1} reais");
        Console.WriteLine($"Preço da Jbl go 3: {precoProduto2} reais");

        pagamento.ProcessarPagamento(cliente1, precoProduto1);

        Console.ReadLine();



    }
    }
