using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroApp.Domain.Models;

namespace CadastroApp.Infra.Data.Repositories
{
    public class PessoaRepository
    {
        static readonly List<Pessoa> _pessoaDB = new List<Pessoa>();

        public void CreatePessoa(Pessoa p)
        {
            _pessoaDB.Add(p);
        }

        public Pessoa GetPessoa(string id)
        {
            return _pessoaDB.Find(p => p.IdPessoa.Equals(id));
        }

        public IEnumerable<Pessoa> GetAllPessoas()
        {
            return _pessoaDB;
        }

        public void UpdatePessoa(Pessoa p)
        {
            Pessoa gp = GetPessoa(p.IdPessoa);

            gp.Nome = p.Nome;
            gp.Genero = p.Genero;
        }

        public void DeletePessoa(Pessoa p)
        {
            _pessoaDB.Remove(p);
        }
    }
}
