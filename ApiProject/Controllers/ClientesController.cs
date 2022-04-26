using ApiProject.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Services.ClienteServices;
using System;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteServices _clienteServices;
        private readonly IMapper _mapper;
        public ClientesController(IClienteServices clienteServices, IMapper mapper)
        {
            _clienteServices = clienteServices;
            _mapper = mapper;
        }

        // GET: api/<ClientesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clientesList = await _clienteServices.GetClientesList();

            var datosVm = _mapper.Map<ClientesDto>(clientesList);

            return Ok(datosVm);
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var clientesObj = await _clienteServices.GetCliente(id);

            var datosVm = _mapper.Map<ClientesDto>(clientesObj);

            return Ok(datosVm);
        }

        // POST api/<ClientesController>
        [HttpPost]
        public async Task<IActionResult> Post(ClientesDto clienteDto)
        {
            var objCliente = _mapper.Map<Clientes>(clienteDto);

            var result = await _clienteServices.AddCliente(objCliente);

            if (result.IdCliente > 0)
                return Ok(result);
            else
                return BadRequest(result);
        }

        // PUT api/<ClientesController>/
        [HttpPut]
        public async Task<IActionResult> Put(ClientesDto clienteDto)
        {
            var objCliente = _mapper.Map<Clientes>(clienteDto);

            var result = await _clienteServices.UpdateCliente(objCliente);

            if (result != null)
                return Ok(result);
            else
                return BadRequest(result);
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _clienteServices.DeleteClienteAsync(id);
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex); }

        }
    }
}

