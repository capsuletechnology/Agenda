using System;
using Agenda.Services;
using SQLiteNetExtensions.Extensions;
using Xamarin.Forms;

namespace Agenda.DAO
{
	public abstract class GenericDAO<T> : IDisposable
	{
		public SQLite.Net.SQLiteConnection _conexao { get; set; }
		public void init()
		{
			var config = DependencyService.Get<IConfig>();
			_conexao = new SQLite.Net.SQLiteConnection(config.Plataforma,
													   System.IO.Path.Combine(config.Diretorio, "banco1.db3"));
			CreateAllTables();

		}

		public void Insert(T objeto)
		{
			_conexao.InsertWithChildren(objeto);
		}

		public void Update(T objeto)
		{
			_conexao.Update(objeto);
		}

		public void Delete(T objeto)
		{
			_conexao.Delete(objeto);
		}
		public void Dispose()
		{
			_conexao.Dispose();
		}

		public void CreateAllTables()
		{
			_conexao.CreateTable<Model.ContatoModel>();
			_conexao.CreateTable<Model.Endereco>();
		}
	}
}
