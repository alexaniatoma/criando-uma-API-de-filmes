using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.CreateFilmeDto
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O titulo do filme é obrigatório")]
        public string Titulo { get; set; }

        [StringLength(50, ErrorMessage = "O tamnho do gênero não pode exceder 50 caracteres")]
        [Required(ErrorMessage = "O genero do filme é obrigatório")]
        public string Genero { get; set; }

        [Range(60, 130)]
        public int Duracao { get; set; }
    }
}
