using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda.DAO
{
    public class ContatoDAO : IDisposable
    {
        private SQLite.Net.SQLiteConnection _conexao;
        public ContatoDAO()
        {
            var config = DependencyService.Get<Services.IConfig>();
            _conexao = new SQLite.Net.SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.Diretorio, "banco1.db3"));
            _conexao.CreateTable<Model.ContatoModel>();
        }

        public void Insert(Model.ContatoModel contato)
        {
            _conexao.Insert(contato);
        }

        public void Update(Model.ContatoModel contato)
        {
            _conexao.Update(contato);
        }

        public void Delete(Model.ContatoModel contato)
        {
            _conexao.Delete(contato);
        }

        public List<Model.ContatoModel> Lista()
        {
            return _conexao.Table<Model.ContatoModel>().OrderBy(cont => cont.Nome).ToList();
        }

        public Model.ContatoModel BuscarPorCodigo(int cod)
        {
            return _conexao.Table<Model.ContatoModel>().FirstOrDefault(cont => cont.Codigo == cod);
        }

        public List<Model.ContatoModel> BuscarPorNome(string nome)
        {
            var query = _conexao.Query<Model.ContatoModel>("SELECT * FROM ContatoModel WHERE Nome = ?", nome);
            return query;
        }

        public string BuscarPorNomeLinq(string nome)
        {
            var query = from cont in _conexao.Table<Model.ContatoModel>() where cont.Nome.StartsWith(nome) select cont;
            return query.FirstOrDefault().Nome;
        }


        public void Dispose()
        {
            _conexao.Dispose();
        }
    }
}
