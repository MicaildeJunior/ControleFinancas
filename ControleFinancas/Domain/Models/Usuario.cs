using System.ComponentModel.DataAnnotations;

namespace ControleFacil.Api.Domain.Models;

public class Usuario
{
    [Key]
    public long Id { get; set; }

    [Required(ErrorMessage = "O campo de E-mail é obrigatório")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "A campo de senha é obrigatória")]
    public string Senha { get; set; } = string.Empty;

    [Required]
    public DateTime DataCadastro { get; set; }
    public DateTime? DataInaticacao { get; set; }

}