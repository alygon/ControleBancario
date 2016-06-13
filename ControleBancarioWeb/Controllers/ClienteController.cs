using ControleBancarioDominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleBancarioWeb.Controllers
{
    public class ClienteController : Controller
    {

        private ClienteRepository _repository;

        // GET: Cliente
        public ActionResult Index()
        {
            _repository = new ClienteRepository();
            var clientes = _repository.Clientes.Take(2);

            return View(clientes);
        }
    }
}