//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample03
{
    using System;
    using System.Collections.Generic;
    
    public partial class PessoaTB
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Obs { get; set; }
        public Nullable<int> CidadeId { get; set; }
    
        public virtual Cidade Cidade { get; set; }
    }
}
