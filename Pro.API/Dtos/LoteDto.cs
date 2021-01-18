using System.ComponentModel.DataAnnotations;

namespace Pro.API.Dtos
{
    public class LoteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]
        public decimal Preço { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        [Range(2, 5)]
        public int Quantidade { get; set; }
    }
}