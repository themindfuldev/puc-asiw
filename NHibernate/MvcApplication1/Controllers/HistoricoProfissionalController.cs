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
    public class HistoricoProfissionalController : Controller
    {
        public ActionResult Index(int id)
        {
            var resultados = Factory.GetAll("Core.Domain.Model.HistoricoProfissional", "Pessoa.IdPessoa", new decimal(id));
            IList<HistoricoProfissionalModel> listaModel = new List<HistoricoProfissionalModel>();
            foreach (HistoricoProfissional resultado in resultados)
            {
                HistoricoProfissionalModel model = new HistoricoProfissionalModel();
                model.Empresa = resultado.Empresa;
                model.DataFim = resultado.DataFim;
                model.DataInicio = resultado.DataInicio;
                model.HabilidadePessoal = resultado.HabilidadesIntraPessoais;
                model.HabilidadeTecnica = resultado.HabilidadesTecnicas;
                model.IdPessoa = decimal.ToInt32(resultado.Pessoa.IdPessoa);
                model.IdHistoricoProfissional = decimal.ToInt32(resultado.IdHistoricoProfissiona);

                listaModel.Add(model);
            }

            return View(listaModel);
        }
        //
        // GET: /HistoricoProfissional/Create/5

        public ActionResult Create(int id)
        {
            return View(new HistoricoProfissionalModel { IdPessoa = id, DataInicio = null, DataFim = null });
        }

        //
        // GET: /HistoricoProfissional/Create
        [HttpPost]
        public ActionResult Create(HistoricoProfissionalModel model)
        {
            if (ModelState.IsValid)
            {
                HistoricoProfissional historicoProfissional = new HistoricoProfissional();
                
                historicoProfissional.Empresa = model.Empresa;
                historicoProfissional.DataFim =  model.DataFim;
                historicoProfissional.DataInicio = model.DataInicio;
                historicoProfissional.HabilidadesIntraPessoais = model.HabilidadePessoal;
                historicoProfissional.HabilidadesTecnicas = model.HabilidadeTecnica;
                historicoProfissional.Pessoa = new Pessoa { IdPessoa = model.IdPessoa };

                Factory.Save(historicoProfissional);
                return RedirectToAction("Index", "HistoricoProfissional", new { id = model.IdPessoa });
            }

            return View();
        }

        //
        // GET: /HistoricoProfissional/Details/5

        public ActionResult Details(int id)
        {
            HistoricoProfissional historicoProfissional = (HistoricoProfissional)Factory.GetById("Core.Domain.Model.HistoricoProfissional", new decimal(id));
            HistoricoProfissionalModel model = new HistoricoProfissionalModel();
            model.Empresa = historicoProfissional.Empresa;
            model.DataFim = historicoProfissional.DataFim;
            model.DataInicio = historicoProfissional.DataInicio;
            model.HabilidadePessoal = historicoProfissional.HabilidadesIntraPessoais;
            model.HabilidadeTecnica = historicoProfissional.HabilidadesTecnicas;
            model.IdPessoa = decimal.ToInt32(historicoProfissional.Pessoa.IdPessoa);
            model.IdHistoricoProfissional = decimal.ToInt32(historicoProfissional.IdHistoricoProfissiona);

            return View(model);
        }   
        
        //
        // GET: /HistoricoProfissional/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /HistoricoProfissional/Edit/5

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
        // GET: /HistoricoProfissional/Delete/5
 
        public ActionResult Delete(int id)
        {
            HistoricoProfissional historicoProfissional = (HistoricoProfissional)Factory.GetById("Core.Domain.Model.HistoricoProfissional", new decimal(id));
            HistoricoProfissionalModel model = new HistoricoProfissionalModel();
            model.Empresa = historicoProfissional.Empresa;
            model.DataFim = historicoProfissional.DataFim;
            model.DataInicio = historicoProfissional.DataInicio;
            model.HabilidadePessoal = historicoProfissional.HabilidadesIntraPessoais;
            model.HabilidadeTecnica = historicoProfissional.HabilidadesTecnicas;
            model.IdPessoa = decimal.ToInt32(historicoProfissional.Pessoa.IdPessoa);
            model.IdHistoricoProfissional = decimal.ToInt32(historicoProfissional.IdHistoricoProfissiona);

            return View(model);
        }

        //
        // POST: /HistoricoProfissional/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            HistoricoProfissional historicoProfissional = (HistoricoProfissional)Factory.GetById("Core.Domain.Model.HistoricoProfissional", new decimal(id));
            Factory.Delete(historicoProfissional);

            return RedirectToAction("Index", "HistoricoProfissional", new { id = historicoProfissional.Pessoa.IdPessoa }); 
        }
    }
}
