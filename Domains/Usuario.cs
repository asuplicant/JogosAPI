using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace JogosAPI.Domains
{
    [Table("Usuario")]
    // O Index faz com que o nome do jogo NÃO se repita.
    [Index(nameof(Nickname), IsUnique = true)]
    // Public Class — Cria uma classe pública.
    public class Usuario
    {
        // Preencher os atributos.
        [Key]
        public Guid UsuarioID { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string? Nome { get; set; }


        [Column(TypeName = "VARCHAR(80)")]
        [Required(ErrorMessage = "O Nickname é obrigatório!")]
        public string? Nickname { get; set; }

        // Foreign Key — JogoFavorito.
        public Guid JogoFavorito { get; set; }
        [ForeignKey("JogoFavorito")]
        public Jogo? Jogo { get; set; }    
    }
}

// O Required faz com que seja obrigatório preencher o campo.

