namespace AplicativoParaGerenciamentoDeUsuarios
{
    // Classe para armazenar as informações do usuário
    public class Usuario
    {
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public int Idade { get; set; }
    }
}
