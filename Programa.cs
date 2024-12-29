using System;
using System.Collections.Generic;

namespace AplicativoParaGerenciamentoDeUsuarios
{
    class Programa
    {
        static void Main(string[] args)
        {
            // Lista para armazenar usuários
            List<Usuario> usuarios = new List<Usuario>();

            // Inicializando a lista de usuários com 30 registros (Opcional)
            // Descomente a linha abaixo se quiser adicionar registros automaticamente
            AdicionarUsuarios.InicializarUsuarios(usuarios); 

            while (true)
            {
                // Opções de Menu.
                Console.WriteLine("\n--- Gerenciador de usuários ---");
                Console.WriteLine("1. Registrar Usuário");
                Console.WriteLine("2. Listar Todos Usuários");
                Console.WriteLine("3. Procurar usuário por nome");
                Console.WriteLine("4. Sair");
                Console.Write("Selecione uma opção: ");

                string? option;
                
                while (true)
                {
                    option = Console.ReadLine();

                    if (!string.IsNullOrEmpty(option))
                    {
                        break; // Sai do loop se a entrada for válida
                    }

                    Console.WriteLine("*** Opção inválida. Por favor, tente novamente. ***");
                }

                switch (option)
                {
                    case "1":
                        FuncoesUsuario.RegistrarUsuario(usuarios);
                        break;
                    case "2":
                        FuncoesUsuario.ListarUsuario(usuarios);
                        break;
                    case "3":
                        FuncoesUsuario.ProcurarUsuario(usuarios);
                        break;
                    case "4":
                        Console.WriteLine("Encerrado. Até breve!");
                        return;
                    default:
                        Console.WriteLine("*** Opção Invalida. Por favor, tente novamente. ***");
                        break;
                }
            }
        }
       
    }
}
