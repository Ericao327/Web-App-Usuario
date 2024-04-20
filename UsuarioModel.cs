using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppUsuario.Models
{
	[Table("Usuario")]
	public class UsuarioModel
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(60)]
		public string nome { get; set; }
		[MaxLength(80)]
		public string Email { get; set; }
		[MaxLength(10, ErrorMessage = "0 tamanho máximo é {1} caracteres!")]
		[MinLength(5, ErrorMessage = "0 tamanho mínimo é {1} caracteres!")]
		public string Senha { get; set; }
		public bool Administrador { get; set; }
		public bool Ativo { get ; set; }
		public DateTime DataDoCadastro { get; set; }
		public DateTime DataDaIniciativa { get; set;}
	}
}
