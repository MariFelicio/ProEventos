using System.ComponentModel.DataAnnotations;

namespace Pro.API.Dtos
{
    public class RedeSocialDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required (ErrorMessage="O campo {0} é obrigatório")]
        public string URL { get; set; }
    }
}