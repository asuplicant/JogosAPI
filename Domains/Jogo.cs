// Namespace — Caminho em que a classe do Jogo está.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace JogosAPI.Domains
{
    [Table("Jogo")]
    // O Index faz com que o nome do jogo NÃO se repita.
    [Index(nameof(NomeDoJogo), IsUnique = true)]
    // Public Class — Cria uma classe pública.
    public class Jogo
    {
        // Preencher os atributos.
        [Key]
        public Guid JogoID { get; set; }

        // O Required faz com que seja obrigatório preencher o campo.
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do Jogo é obrigatório!")]
        public string? NomeDoJogo { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "A Plataforma é obrigatória!")]
        public string? Plataforma { get; set; }
    }
}
