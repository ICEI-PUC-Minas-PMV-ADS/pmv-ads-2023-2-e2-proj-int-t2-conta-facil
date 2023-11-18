using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Schema;

namespace ContaFacil2.Models
{
    [Table("Reservas")] // Tabela que será criada no banco de dados 
    public class Reserva
    {
        [Key] // Indicando a chave primária 
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor informe o seu salário!")] // Informar que o campo é requirido, obrigatório
        [Display(Name = "Salário")]
        public double salario { get; set; }

        [Required(ErrorMessage = "Por favor informe o valor total ou aproximado dos seus gastos essenciais! ")]
        [Display(Name = "Total dos Gastos Essenciais")]
        public double totalEssenciais { get; set; }

        [Required(ErrorMessage = "Por favor informe o valor total ou aproximado dos seus gastos não essenciais!")]
        [Display(Name = "Total dos Gastos  não Essenciais")]
        public double totalNaoEssenciais { get; set; }

        [Display(Name = "O Valor a investir na sua Reserva Emergêncial é de:")]
        public double investimento { get; set; }

    }
}
