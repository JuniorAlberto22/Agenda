using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agenda.DTOs;

namespace Agenda.DTOs
{
    public class AtividadeDTO
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public List<PessoaDTO> pessoas { get; set; }
    }
}