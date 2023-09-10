using System;

namespace RespUnica
{
	class Pagamento
	{
		public void ProcessarPagamento(Cliente cliente, double total)
		{
			// L�gica para processar o pagamento aqui
			Console.WriteLine($"Pagamento de {total} processado para o cliente {cliente.Nome} ({cliente.Email})");
		}
	}
}