using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JonnathanPersonagemBanco.Models.Contexto
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {
            
        }

        public System.Data.Entity.DbSet<JonnathanPersonagemBanco.Models.Character> Characters { get; set; }
    }
}