using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required (ErrorMessage = "O titulo do filme é obrigatório")]
        
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O genero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public string  Genero { get; set; }

        [Range (60, 130)]
        public int Duracao { get; set; }
    }
}
