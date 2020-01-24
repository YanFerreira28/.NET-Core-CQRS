using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjetoCQRS.Domain.Command;
using ProjetoCQRS.Domain.Contracts;
using ProjetoCQRS.Domain.Entities;

namespace ProjetoCQQRS.UI.Controllers
{
    public class ClienteController : Controller
    {
        public IClienteRepository _cliente;
        public IMediator _mediator;

        public ClienteController(IMediator mediator, IClienteRepository clienteRepository)
        {
            _cliente = clienteRepository;
            _mediator = mediator;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Index()
        {
            var x =  _cliente.GetAll();

            return View(x);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Register(RegisterClienteCommand obj)
        {
            var response = await _mediator.Send(obj);

            return Created("201", response);
        }

        public async Task<Cliente> Update(int ide)
        {
            return await _cliente.Buscar(c => c.id == ide);
        }

        public async Task<IActionResult> Update(UpdateClienteCommand obj)
        {
            var x = await _mediator.Send(obj);
            return Ok(x);
        }

        public IActionResult Delete(int id)
        {
            var cliRemove = _cliente.Buscar(c => c.id == id);

            return View(cliRemove);
        }

        public async Task<IActionResult> Delete(DeleteClienteCommand obj)
        {
            var x = await _mediator.Send(obj);

            return Ok(x);
        }
    }
}