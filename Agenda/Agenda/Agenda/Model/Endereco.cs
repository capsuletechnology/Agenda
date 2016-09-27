using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace Agenda.Model
{
	[Table("Endereco")]
	public class Endereco
	{
		[PrimaryKey, AutoIncrement]
		public int Codigo { get; set;}
		[MaxLength(70)]
		public string Rua { get; set;}
		public string Numero { get; set;}
		public string Logradouro { get; set;}
		[ForeignKey(typeof(Model.ContatoModel))]
		public int codigoContato { get; set; }
	}
}
