using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agenda.DTOs;
using Agenda.Models;

namespace Agenda.Controllers
{
    public class GerenciadorContatoController : Controller
    {
        public ActionResult Cadastro(PessoaDTO DTO)
        {
            Pessoa pessoa = new Pessoa()
            {
                Email = DTO.Email,
                Nome = DTO.Nome
            };

            pessoa.SaveChanges();

            return RedirectToAction("Index", "HelloWorld");
        }

        // GET: GerenciadorContatos
        public ActionResult Index(int idContato = 0)
        {
            PessoaDTO pessoa = new PessoaDTO()
            {
                Nome = "Junior",
                Email = "gmail@gmail.com",
                Telefones = new List<TelefoneDTO>()
                {
                    new TelefoneDTO(){
                        Id = 30,
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

        public ActionResult DeletarContato(int idContato)
        {
            return RedirectToAction("Index", "HelloWorld");
        }

        public ActionResult EditarContato(int idContato)
        {
            return RedirectToAction("Index", new { idContato = idContato });
        }

        public ActionResult DeletarTelefone(int idTelefone)
        {
            return RedirectToAction("Index");
        }

        public void EditarTelefone( int idTelefone)
        {
            ViewBag.TelEdit = new TelefoneDTO()
            {
                Id = 30,
                Tel = "Ola Mundo",
                Tipo = new TipoTelefoneDTO()
                {
                    Descricao = "Residencial"
                }
            };
        }

        public ActionResult SalvarTelefone(TelefoneDTO Telefone)
        {
            return null;
        }
    }
}