using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agenda.DTOs;

namespace Agenda.Controllers
{
    public class GerenciadorContatoController : Controller
    {
        // GET: GerenciadorContatos
        public ActionResult Index()
        {
            PessoaDTO pessoa = new PessoaDTO()
            {
                Nome = "Junior",
                Email = "gmail@gmail.com",
                Telefones = new List<TelefoneDTO>()
                {
                    new TelefoneDTO(){
                        Tel="(99) 9999-9999",
                        Tipo = new TipoTelefoneDTO()
                        {
                            Descricao="Residencial"
                        }
                    },
                    new TelefoneDTO(){
                        Tel="(99) 9999-9999",
                        Tipo = new TipoTelefoneDTO()
                        {
                            Descricao="Movel"
                        }
                    }
                }
            };

            return View(pessoa);
        }
    }
}