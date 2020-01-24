using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoCQRS.Domain.Command;
using ProjetoCQRS.Domain.Contracts;
using ProjetoCQRS.Domain.Entities;

namespace ProjetoCQRS.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public IMediator _mediator;
        public IClienteRepository _repository;

        public ClienteController(IMediator mediator, IClienteRepository clienteRepository)
        {
            _mediator = mediator;
            _repository = clienteRepository;
        }
        // GET: api/Cliente
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cli = await _repository.GetAll();
            return Ok(cli);
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            var cli = await _repository.GetById(id);
            return Ok(cli);
        }

        // POST: api/Cliente
        [HttpPost]
        public async Task<IActionResult> Post(RegisterClienteCommand obj)
        {
            var clienteResponse =await _mediator.Send(obj);
            return Created("201", clienteResponse);

        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateClienteCommand obj)
        {
            var clienteResponse = await _mediator.Send(obj);
            return Ok(clienteResponse);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(DeleteClienteCommand obj)
        {
            var cliente = await _mediator.Send(obj);
            return Ok(cliente);
        }
    }
}
