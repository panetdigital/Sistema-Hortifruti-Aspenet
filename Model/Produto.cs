using System.ComponentModel.DataAnnotations;

namespace NovoProjetoFrutas.Model
{
    public class Produto
    {
        [Key]  // Define a propriedade Id como a chave primária
        public int Id { get; set; }

        [Required]  // Define que a propriedade é obrigatória
        public string Cod { get; set; }

        [Required]
        public string CodItem { get; set; }

        [Required]
        [MaxLength(100)]  // Define o tamanho máximo da string
        public string Nome { get; set; }

        [DataType(DataType.Currency)]  // Define o tipo de dado como moeda
        public decimal? Preco { get; set; }

        [DataType(DataType.Currency)]
        public decimal? PrecoPromo { get; set; }  // Propriedade nullable para promoções

        [MaxLength(50)]
        public string Grupo { get; set; }

  
        public int EstoqueDisponivel { get; set; }

        [Url]  // Define que a propriedade deve ser um URL válido
        public string Link { get; set; }

        [Url]
        public string Imagem { get; set; }
    }
}
