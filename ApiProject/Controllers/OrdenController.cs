using ApiProject.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Services.OrdenServices;
using System;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenController : ControllerBase
    {

        private readonly IOrdenServices _OrdenServices;
        private readonly IMapper _mapper;
        public OrdenController(IOrdenServices OrdenServices, IMapper mapper)
        {
            _OrdenServices = OrdenServices;
            _mapper = mapper;
        }

        // GET: api/<OrdenController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ordenList = await _OrdenServices.GetOrdenList();

            var datosVm = _mapper.Map<OrdenDto>(ordenList);

            return Ok(datosVm);
        }

        // GET api/<OrdenController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var clientesObj = await _OrdenServices.GetOrden(id);

            var datosVm = _mapper.Map<OrdenDto>(clientesObj);

            return Ok(datosVm);
        }

        // POST api/<OrdenController>
        [HttpPost]
        public async Task<IActionResult> Post(OrdenDto ordenDto)
        {
            var objOrden = _mapper.Map<Orden>(ordenDto);

            var result = await _OrdenServices.AddOrden(objOrden);

            if (result.IdOrden > 0)
                return Ok(result);
            else
                return BadRequest(result);
        }

        // PUT api/<OrdenController>/5
        [HttpPut]
        public async Task<IActionResult> PutAsync(OrdenDto ordenDto)
        {
            var objOrden = _mapper.Map<Orden>(ordenDto);

            var result = await _OrdenServices.UpdateOrden(objOrden);

            if (result != null)
                return Ok(result);
            else
                return BadRequest(result);
        }

        // DELETE api/<OrdenController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _OrdenServices.DeleteOrdenAsync(id);
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex); }
        }
    }
}
