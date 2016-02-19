using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample03.DAL
{
    public class BllCidades
    {
        public IQueryable<Cidade> Retrive()
        {
            return new DALCidades().AcessaCidade();
        }

        public IQueryable<Cidade> Retrive(string descricao)
        {
            return new DALCidades().AcessaCidade(descricao);
        }

        public void Add(Cidade c)
        {
            new DALCidades().Add(c);
        }

        public void Update(Cidade c)
        {
            new DALCidades().Update(c);
        }

        public void Delete(int IdCidade)
        {
            new DALCidades().Delete(IdCidade);
        }
    }
}