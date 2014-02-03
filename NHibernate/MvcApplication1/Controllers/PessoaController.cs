using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using Core.Domain.Model;
using Core.Domain.Repositories;

namespace MvcApplication1.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            var resultados = Factory.GetAll("Core.Domain.Model.Pessoa");
            IList<PessoaModel> listaModel = new List<PessoaModel>();
            foreach (Pessoa resultado in resultados)
            {
                PessoaModel model = new PessoaModel();
                model.CPF = resultado.Cpf;
                model.DataNascimento = resultado.DataNascimento;
                model.IdentidadeEstrangeira = resultado.IdentificacaoEstrangeiro;
                model.Nome = resultado.Nome;
                model.NomeMae = resultado.NomeMae;
                model.NomePai = resultado.NomePai;
                model.RG = resultado.Rg;
                model.Estrangeiro = resultado.Estrangeiro;
                model.IdPessoa = decimal.ToInt32(resultado.IdPessoa);

                listaModel.Add(model);
            }

            return View(listaModel);
        }

        //
        // GET: /Pessoa/Details/5

        public ActionResult Details(int id)
        {
            Pessoa pessoa = (Pessoa)Factory.GetById("Core.Domain.Model.Pessoa", new decimal(id));
            PessoaModel model = new PessoaModel();
            model.CPF = pessoa.Cpf;
            model.DataNascimento = (DateTime) pessoa.DataNascimento;
            model.Estrangeiro = pessoa.Estrangeiro;
            model.IdentidadeEstrangeira = pessoa.IdentificacaoEstrangeiro;
            model.IdPessoa = decimal.ToInt32(pessoa.IdPessoa);
            model.Nome = pessoa.Nome;
            model.NomeMae = pessoa.NomeMae;
            model.NomePai = pessoa.NomePai;
            model.RG = pessoa.Rg;

            return View(model);
        }

        //
        // GET: /Pessoa/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // GET: /Pessoa/Create
        [HttpPost]
        public ActionResult Create(PessoaModel model)
        {
            if (ModelState.IsValid)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = model.Nome;
                pessoa.NomeMae = model.NomeMae;
                pessoa.Cpf = model.CPF;
                pessoa.NomePai = model.NomePai;
                pessoa.Rg = model.RG;
                pessoa.DataNascimento = model.DataNascimento;
                pessoa.Estrangeiro = model.Estrangeiro;
                pessoa.IdentificacaoEstrangeiro = model.IdentidadeEstrangeira;
                Factory.Save(pessoa);
                return RedirectToAction("Create", "Endereco", new { id = pessoa.IdPessoa });
            }
            return View();
        }

        //
        // GET: /Pessoa/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pessoa/Delete/5

        public ActionResult Delete(int id)
        {
            Pessoa pessoa = (Pessoa)Factory.GetById("Core.Domain.Model.Pessoa", new decimal(id));
            PessoaModel model = new PessoaModel();
            model.CPF = pessoa.Cpf;
            model.DataNascimento = (DateTime)pessoa.DataNascimento;
            model.Estrangeiro = pessoa.Estrangeiro;
            model.IdentidadeEstrangeira = pessoa.IdentificacaoEstrangeiro;
            model.IdPessoa = decimal.ToInt32(pessoa.IdPessoa);
            model.Nome = pessoa.Nome;
            model.NomeMae = pessoa.NomeMae;
            model.NomePai = pessoa.NomePai;
            model.RG = pessoa.Rg;

            return View(model);
        }

        //
        // POST: /Pessoa/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Pessoa pessoa = (Pessoa)Factory.GetById("Core.Domain.Model.Pessoa", new decimal(id));
            Factory.Delete(pessoa);

            return RedirectToAction("Index", "Pessoa"); 
        }
    }
}
