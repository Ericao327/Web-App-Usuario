using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppUsuario.Models
{
	[Table("Cliente")]
	public class ClienteModel
	{
		[Key]
		public int Id { get; set; }
		[MaxLength(60)]
		public string nome { get; set;}
		[MaxLength(80)]
		public string Email { get; set;}
		[MaxLength(80)]
		public string Celular { get; set;}
		[MaxLength(11)]
		public string Cidade { get; set;}
		public bool Administrador { get; set;}
		public bool Ativo { get ; set;}
		public DateTime DataDoCadastro { get; set;}
		public DateTime DataDaIniciativa { get; set;}

	}
}
