using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContaFacil2.Models
{
    [Table("Cadastros")]
    public class Cadastro
    {
                
            [Key]
            public int IdUsuario { get; set; }
            [Required(ErrorMessage = "Obrigatorio")]
            public string Nome { get; set; }
            [Required(ErrorMessage = "Obrigatorio")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Obrigatorio")]
            public string Logadouro { get; set; }
            [Required(ErrorMessage = "Obrigatorio")]
            public string Cidade { get; set; }
            [Required(ErrorMessage = "Obrigatorio")]
            public string Uf { get; set; }
            [Required(ErrorMessage = "Obrigatorio")]
            public string CEP { get; set; }
            [Required(ErrorMessage = "Obrigatorio")]
            public string Telefone { get; set; }
            [Required(ErrorMessage = "Obrigatorio")]
            public string Cpf { get; set; }
            [Required(ErrorMessage = "Obrigatorio")]
            [DataType(DataType.Password)]
            public string Senha { get; set; }
            public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
