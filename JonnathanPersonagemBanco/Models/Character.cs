using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JonnathanPersonagemBanco.Models
{
    public class Character
    {
        public int CharacterID { get; set; }
        public string Nome { get; set; }
        public string Origem { get; set; }
        public string Historia { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }

    }
}