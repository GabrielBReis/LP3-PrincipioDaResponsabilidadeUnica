// See https://aka.ms/new-console-template for more information
using RespUnica;

namespace RespUnica
{
    class PrincipioDaResponsabilidadeUnica
    {
        static void Main()
        {
            RespUnica.Cliente cliente = new Cliente("Gabriel", "gab@gmail.com");
            Console.WriteLine("Nome "+cliente.nome);

            Console.WriteLine("Pressione Enter para encerrar...");
            Console.ReadLine(); // Aguarda a entrada do usuário
        }
    }
}
