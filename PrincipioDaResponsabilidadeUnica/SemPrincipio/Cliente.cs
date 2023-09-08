using System;

namespace SemRespUnica
{
    class Cliente
    {
        public string Nome { get; }
        public string Email { get; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
