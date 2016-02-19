using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample03.DAL
{
    public class BllPessoas
    {
        public IQueryable<PessoaTB> Retrive()
        {
            return new DALPessoas().AcessaPessoa();
        }

        public IQueryable<PessoaTB> Retrive(string descricao)
        {
            return new DALPessoas().AcessaPessoa(descricao);
        }

        public void Add(PessoaTB p)
        {
            new DALPessoas().Add(p);
        }

        public void Update(PessoaTB c)
        {
            new DALPessoas().Update(c);
        }

        public void Delete(int IdPessoa)
        {
            new DALPessoas().Delete(IdPessoa);
        }
    }
}