using System;
using System.Collections.Generic;

namespace AplicativoParaGerenciamentoDeUsuarios
{
    // Classe com as funções de usuário
    public static class FuncoesUsuario
    {
        // Metodo para registrar usuário
        public static void RegistrarUsuario(List<Usuario> usuarios)
        {
            Console.Write("Digite o nome: ");
            string? nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("\n*** Nome não pode ser vazio. Registro não realizado. ***");
                return;
            }

            Console.Write("Digite o Email: ");
            string? email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("\n*** Email não pode ser vazio. Registro não realizado. ***");
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("\n*** Email inválido. Registro não realizado. ***");
                return;
            }

            Console.Write("Digite a Idade: ");
            if (!int.TryParse(Console.ReadLine(), out int Idade))
            {
                Console.WriteLine("\n*** Idade inválida. Registro não realizado. ***");
                return;
            }

            usuarios.Add(new Usuario { Nome = nome, Email = email, Idade = Idade });
            Console.WriteLine("\n*** Usuário registrado com sucesso. ***");
        }

        // Metodo para listar todos os usuários registrados
        public static void ListarUsuario(List<Usuario> usuarios)
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("\n*** Nenhum usuário registrado. ***");
                return;
            }

            Console.WriteLine("\n--- Usuários registrados ---");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Nome: {usuario.Nome}, Email: {usuario.Email}, Idade: {usuario.Idade}");
            }
        }

        // Metodo para buscar usuário pelo nome
        public static void ProcurarUsuario(List<Usuario> usuarios)
        {
            Console.Write("Digite o início do nome para procurá-lo: ");
            string? nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("\n*** O valor de busca não pode estar vazio. ***");
                return;
            }

            // Busca todos os usuários cujo nome começa com a substring digitada
            var usuariosEncontrados = usuarios.FindAll(usuario => usuario.Nome.StartsWith(nome, StringComparison.OrdinalIgnoreCase));

            if (usuariosEncontrados.Count > 0)
            {
                Console.WriteLine("\nUsuários encontrados:");
                foreach (var usuario in usuariosEncontrados)
                {
                    Console.WriteLine($"Nome: {usuario.Nome}, Email: {usuario.Email}, Idade: {usuario.Idade}");
                }
            }
            else
            {
                Console.WriteLine("\n*** Nenhum usuário encontrado. ***");
            }
        }
    }
}
