//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbprodutos
    {
        public long ProdutoID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public long Status { get; set; }
        public string Categorias { get; set; }
        public string Tags { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPromocional { get; set; }
    }
}
