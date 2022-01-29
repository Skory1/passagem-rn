using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Passagem.Models
{
    public class Noticias
    {
        [Key]
        public int NoticiaId { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string ResumoMateria { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Conteudo { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaFK { get; set; }
        
        public virtual Categorias Categoria { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.Now;
        public DateTime AtualizadoEm { get; set; } = DateTime.Now;
    }
}