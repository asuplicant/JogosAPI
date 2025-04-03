using JogosAPI.Context;
using JogosAPI.Domains;
using JogosAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static JogosAPI.Context.JogosAPI_Context;

namespace JogosAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly JogosAPI_Context _context;
        public UsuarioRepository()
        {
            _context = new JogosAPI_Context();
        }


        //-----------------------------------------------------
        // Cadastrar Usuário
        public void Cadastrar(Usuario novoUsuario)
        {
            try
            {
                _context.Usuario.Add(novoUsuario);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Atualizar Usuário
        public void Atualizar(Guid id, Usuario usuario)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario.Find(id)!;

                if (usuario != null)
                {
                    usuario.Nome = usuario.Nome;
                    usuario.Nickname = usuario.Nickname;
                }

                _context.Usuario.Update(usuario!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //-----------------------------------------------------
        // Listar Usuário
        public List<Usuario> Listar()
        {
            try
            {
                return _context.Usuario.ToList();
            }
            catch (Exception)
            {
                return new List<Usuario>();

            }

        }

        //-----------------------------------------------------
        // Deletar Usuário
        void IUsuarioRepository.Deletar(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario.Find(id)!;

                if (usuarioBuscado != null)
                {
                    _context.Usuario.Remove(usuarioBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}