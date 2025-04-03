using JogosAPI.Context;
using JogosAPI.Domains;
using JogosAPI.Interfaces;

namespace JogosAPI.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly JogosAPI_Context _context;
        public JogoRepository()
        {
            _context = new JogosAPI_Context();
        }


        //-----------------------------------------------------
        // Cadastrar Jogo
        public void Cadastrar(Jogo novoJogo)
        {
            try
            {
                _context.Jogo.Add(novoJogo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //-----------------------------------------------------
        // Atualizar Jogo
        public void Atualizar(Guid id, Jogo jogo)
        {
            try
            {
                Jogo jogoBuscado = _context.Jogo.Find(id)!;

                if (jogo != null)
                {
                    jogo.NomeDoJogo = jogo.NomeDoJogo;
                    jogo.Plataforma = jogo.Plataforma;
                }

                _context.Jogo.Update(jogo!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //-----------------------------------------------------
        // Listar Jogo
        public List<Jogo> Listar()
        {
            try
            {
                return _context.Jogo.Select(e => new Jogo
                {
                    JogoID = e.JogoID,
                    NomeDoJogo = e.NomeDoJogo,
                    Plataforma = e.Plataforma
                }).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        //-----------------------------------------------------
        // Deletar Jogo
        void IJogoRepository.Deletar(Guid id)
        {
            try
            {
                Jogo jogoBuscado = _context.Jogo.Find(id)!;

                if (jogoBuscado != null)
                {
                    _context.Jogo.Remove(jogoBuscado);
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