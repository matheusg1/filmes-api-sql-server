using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos.Gerente
{
    public class CreateGerenteDto
    {
        [Required(ErrorMessage = "O campo {} é obrigatório")]
        public string Nome { get; set; }
    }
}
