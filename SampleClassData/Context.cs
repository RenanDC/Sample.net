using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace SampleClassData
{
    public class Context
    {
        DataClasses1DataContext scd = new DataClasses1DataContext();

        public Table<PessoaTB> GetPessoas()
        {
            return scd.PessoaTBs;
        }

        public PessoaTB GetPessoa(int pessoaID)
        {
            PessoaTB pessoa = scd.PessoaTBs.SingleOrDefault(p => p.PessoaId.Equals(pessoaID));
            return pessoa;
        }

        public IQueryable<PessoaTB> GetPessoas(string pessoa)
        {
            IQueryable<PessoaTB> iqPessoa = GetPessoas().AsQueryable<PessoaTB>();

            if (pessoa != null)
                iqPessoa = scd.PessoaTBs.Where(p => p.Nome.Contains(pessoa));

            return iqPessoa;
        }

        public void AddPessoa(PessoaTB p)
        {
            scd.PessoaTBs.InsertOnSubmit(p);
            scd.SubmitChanges();
        }

        public void DeletePessoa(int pessoaId)
        {
            PessoaTB pessoa = scd.PessoaTBs.SingleOrDefault(p => p.PessoaId.Equals(pessoaId));
            scd.PessoaTBs.DeleteOnSubmit(pessoa);
            scd.SubmitChanges();
        } 
        
        public void UpdatePessoa(PessoaTB p)
        {
            PessoaTB context = scd.PessoaTBs.SingleOrDefault(q => q.PessoaId.Equals(p.PessoaId));
            context.Nome = p.Nome;
            context.Obs = p.Obs;
            context.Telefone = p.Telefone;
            scd.SubmitChanges();
        }    
    }
}
