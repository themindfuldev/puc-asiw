using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Domain.Model;
using MvcApplication1.Models;
using Core.Domain.Repositories;

namespace MvcApplication1.Controllers
{
    public class EnderecoController : Controller
    {
        //
        // GET: /Create/5

        public ActionResult Create(int id)
        {
            EnderecoModel enderecoModel = (EnderecoModel) Session["endereco"];

            if (enderecoModel == null)
            {
                enderecoModel = new EnderecoModel { IdPessoa = id };
            }

            return View(enderecoModel);
        }

        //
        // GET: /Endereco/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EnderecoModel model)
        {

            if (model.CEP != null)
            {                
                if (obterEndereco(model) == true)
                {
                    model.Complemento = String.Empty;
                    model.Pais = String.Empty;
                }
                else
                {
                    model.CEP = String.Empty;
                    model.Logradouro = String.Empty;
                    model.Numero = String.Empty;
                    model.Complemento = String.Empty;
                    model.Bairro = String.Empty;
                    model.Cidade = String.Empty;
                    model.Estado = String.Empty;
                    model.Pais = String.Empty;
                }

                Session["endereco"] = model;
                return RedirectToAction("Create", "Endereco", new { id = model.IdPessoa });
            }             

            return View();
        }

        [HttpPost]
        public ActionResult CepObtido(EnderecoModel model)
        {

            if (ModelState.IsValid)
            {
                Endereco endereco = new Endereco();
                endereco.Bairro = model.Bairro;
                endereco.Cep = model.CEP;
                endereco.Cidade = model.Cidade;
                endereco.Estado = model.Estado;
                endereco.Logradouro = model.Logradouro;
                endereco.Complemento = model.Complemento;
                endereco.Numero = model.Numero;
                endereco.Pais = model.Pais;
                endereco.Pessoa = new Pessoa { IdPessoa = model.IdPessoa };

                Factory.Save(endereco);

                Session["endereco"] = null;

                return RedirectToAction("Create", "HistoricoAcademico", new { id = model.IdPessoa });             
            }

            return View();
        }

        //
        // GET: /Endereco/Index

        public ActionResult Index()
        {

            return View();
        }

        //
        // GET: /Endereco/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Endereco/Edit/5

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
        // GET: /Endereco/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Endereco/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public bool obterEndereco(EnderecoModel enderecoModel)
        {
            // var cep = "35900371";
            var wcfservice = new Cadastro.ServiceReference1.Service1Client();
            var enderecoWcf = wcfservice.ObterCep(enderecoModel.CEP);

            if (enderecoWcf != null)
            {
                enderecoModel.Logradouro = enderecoWcf.Logradouro;
                enderecoModel.Numero = enderecoWcf.Numero.ToString();
                enderecoModel.Bairro = enderecoWcf.Bairro;
                enderecoModel.Cidade = enderecoWcf.Municipio;
                enderecoModel.Estado = enderecoWcf.Uf;

                return true;
            }
            return false;
        }
    }

    
}
