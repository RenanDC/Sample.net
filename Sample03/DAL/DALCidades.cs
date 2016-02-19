using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample03.DAL
{
    public class DALCidades
    {
        public IQueryable<Cidade> AcessaCidade()
        {
            return SampleDbContext.Current.Cidades;
        }

        public IQueryable<Cidade> AcessaCidade(string descricaoCidade)
        {            
            return SampleDbContext.Current.Cidades.Where(q => q.Descricao.Contains(descricaoCidade));
        }

        public void Add(Cidade c)
        {
            SampleDbContext.Current.Cidades.Add(c);
            SampleDbContext.Current.SaveChanges();
            SampleDbContext.Current.ChangeTracker.Entries<Cidade>();
        }

        public void Update(Cidade CidadeNova)
        {
            try {
                Cidade cDB = AcessaCidade().FirstOrDefault(p => p.CidadeId == CidadeNova.CidadeId);
                if (cDB == null)
                    throw new Exception("Cidade não encontrada");
                SampleDbContext.Current.Entry(cDB).CurrentValues.SetValues(CidadeNova);
                SampleDbContext.Current.Entry(cDB).State = System.Data.EntityState.Modified;
                SampleDbContext.Current.SaveChanges();
                SampleDbContext.Current.ChangeTracker.Entries<Cidade>();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Delete(int IdCidade)
        {
            try
            {
                Cidade cidade = AcessaCidade().FirstOrDefault(p => p.CidadeId == IdCidade);
                if (cidade == null)
                    throw new Exception("Cidade não encontrada");
                
                SampleDbContext.Current.Entry(cidade).State = System.Data.EntityState.Deleted;
                SampleDbContext.Current.SaveChanges();
                SampleDbContext.Current.ChangeTracker.Entries<Cidade>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}