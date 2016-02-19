using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample03.DAL
{
    public class DALPessoas
    {
        public IQueryable<PessoaTB> AcessaPessoa()
        {
            return SampleDbContext.Current.PessoaTBs;
        }

        public IQueryable<PessoaTB> AcessaPessoa(string descricaoPessoa)
        {
            return SampleDbContext.Current.PessoaTBs.Where(q => q.Nome.Contains(descricaoPessoa));
        }

        public void Add(PessoaTB p)
        {
            SampleDbContext.Current.PessoaTBs.Add(p);
            SampleDbContext.Current.SaveChanges();
            SampleDbContext.Current.ChangeTracker.Entries<PessoaTB>();
        }

        public void Update(PessoaTB pessoaNova)
        {
            try
            {
                PessoaTB pDB = AcessaPessoa().FirstOrDefault(p => p.PessoaId == pessoaNova.PessoaId);
                if (pDB == null)
                    throw new Exception("Cidade não encontrada");
                SampleDbContext.Current.Entry(pDB).CurrentValues.SetValues(pessoaNova);
                SampleDbContext.Current.Entry(pDB).State = System.Data.EntityState.Modified;
                SampleDbContext.Current.SaveChanges();
                SampleDbContext.Current.ChangeTracker.Entries<PessoaTB>();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Delete(int IdPessoa)
        {
            try
            {
                PessoaTB cidade = AcessaPessoa().FirstOrDefault(p => p.PessoaId == IdPessoa);
                if (cidade == null)
                    throw new Exception("Pessoa não encontrada");

                SampleDbContext.Current.Entry(cidade).State = System.Data.EntityState.Deleted;
                SampleDbContext.Current.SaveChanges();
                SampleDbContext.Current.ChangeTracker.Entries<PessoaTB>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}