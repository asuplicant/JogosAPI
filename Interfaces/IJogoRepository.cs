using JogosAPI.Domains;

namespace JogosAPI.Interfaces
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo novoJogo);

        void Atualizar(Guid id, Jogo jogo);

        void Deletar(Guid id);

        List<Jogo> Listar();
    }
}
