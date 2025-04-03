using JogosAPI.Domains;

namespace JogosAPI.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario novoUsuario);

        void Atualizar(Guid id, Usuario usuario);

        void Deletar(Guid id);

        List<Usuario> Listar();
    }
}
