using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Agenda.DAO
{
	public class EnderecoDAO : GenericDAO<Model.Endereco>
	{
		public EnderecoDAO()
		{
			init();
		}

		public List<Model.Endereco> Lista()
		{
			return _conexao.Table<Model.Endereco>().OrderBy(cont => cont.Codigo).ToList();
		}

		//public Model.Endereco BuscarPorCodigo(int cod)
		//{
		//	return _conexao.Table<Model.Endereco>().FirstOrDefault(cont => cont.Codigo == cod);
		//}

		//public List<Model.Endereco> BuscarPorNome(string nome)
		//{
		//	var query = _conexao.Query<Model.Endereco>("SELECT * FROM Endereco WHERE Nome = ?", nome);
		//	return query;
		//}

		//public string BuscarPorNomeLinq(string nome)
		//{
		//	var query = from cont in _conexao.Table<Model.Endereco>() where cont.Nome.StartsWith(nome) select cont;
		//	return query.FirstOrDefault().Nome;
		//}
	}
}
