using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Extensions;
using Xamarin.Forms;

namespace Agenda.DAO
{
	public class ContatoDAO : GenericDAO<Model.ContatoModel>
	{

		public ContatoDAO()
		{
			init();
		}

		public List<Model.ContatoModel> Lista()
		{
			return _conexao.Table<Model.ContatoModel>().OrderBy(cont => cont.Nome).ToList();
		}

		//public Model.ContatoModel BuscarPorCodigo(int cod)
		//{
		//	return _conexao.Table<Model.ContatoModel>().FirstOrDefault(cont => cont.Codigo == cod);
		//}

		//public List<Model.ContatoModel> BuscarPorNome(string nome)
		//{
		//	var query = _conexao.Query<Model.ContatoModel>("SELECT * FROM ContatoModel WHERE Nome = ?", nome);
		//	return query;
		//}

		//public string BuscarPorNomeLinq(string nome)
		//{
		//	var query = from cont in _conexao.Table<Model.ContatoModel>() where cont.Nome.StartsWith(nome) select cont;
		//	return query.FirstOrDefault().Nome;
		//}
	}
}
