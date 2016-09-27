using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    [Table("Contato")]
    public class ContatoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Codigo { get; set; }
		[MaxLength(70)]
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
		[OneToMany(CascadeOperations = CascadeOperation.All)]
		public List<Endereco> Enderecos { get; set; }

    }
}
