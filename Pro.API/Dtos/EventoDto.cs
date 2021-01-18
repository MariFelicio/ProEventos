using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pro.API.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        [Required (ErrorMessage="Campo obrigatório")]
        [StringLength (100, MinimumLength=3, ErrorMessage="Local é entre 3 e 100 caracters")]
        public string Local { get; set; }
        public string DataEvento { get; set; }
        [Required (ErrorMessage="O tema é obrigatório")]
        public string Tema { get; set; }
        [Range (1, 350, ErrorMessage="Quantidade de pessoas deve ser entre 1 e 350")]
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<LoteDto> Lotes { get; set; }
        public List<RedeSocialDto> RedeSociais { get; set; } 
        public List<PalestranteDto> Palestrantes { get; set; }
    }
}