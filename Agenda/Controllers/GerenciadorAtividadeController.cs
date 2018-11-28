using System;
using System.Web.Mvc;
using Agenda.DTOs;
using System.Collections.Generic;

namespace Agenda.Controllers
{
    public class GerenciadorAtividadeController : Controller
    {
        // GET: GerenciadorAtividade
        public ActionResult Index()
        {
            AtividadeDTO atividade = new AtividadeDTO()
            {
                Titulo = "Ola Mundo",
                Descricao = "Essa é minha maravilhosa atividade",
                DataHora = new DateTime(),
                pessoas= new List<PessoaDTO>()
                {
                    new PessoaDTO()
                    {
                        Nome="Alberto",
                        Email="email@gmail",
                        Checked=true

                    },
                    new PessoaDTO()
                    {
                        Nome="José",
                        Email="email@gmail",
                        Checked=true
                    }
                }
            };
            return View(atividade);
        }

        [HttpPost]
        public ActionResult Cadastro(AtividadeDTO atividade)
        {
            Console.WriteLine("{0} {1} {2} {3}", atividade.Titulo, atividade.Descricao, atividade.DataHora, atividade.DataHora);
            return RedirectToAction("Index", "GerenciadorAtividade");
        }

        public static Object RemoverPessoa(int index, List<PessoaDTO> pessoas)
        {
            int i = 0;
            foreach(var p in pessoas)
            {
                if (i == index)
                {
                    p.Checked = false;
                    Console.WriteLine("Chamado");
                    return p;
                }
                i++;
            }
            return null;
        }
    }
}