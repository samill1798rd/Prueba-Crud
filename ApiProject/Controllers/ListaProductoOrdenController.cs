using ApiProject.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Services.ListaProductosOrdenServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaProductoOrdenController : ControllerBase
    {
        private readonly IListaProductoOrdenServices _listaProductoOrdenServices;
        private readonly IMapper _mapper;
        public ListaProductoOrdenController(IListaProductoOrdenServices listaProductoOrdenServices, IMapper mapper)
        {
            _listaProductoOrdenServices = listaProductoOrdenServices;
            _mapper = mapper;
        }

        // GET: api/<ListaProductoOrdenController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ListaProductoOrdenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ListaProductoOrdenController>
        [HttpPost]
        public async Task<IActionResult> Post(ListaProductoByOrdenDto listaProductDto)
        {
            var objProducto= _mapper.Map<ListaProductoByOrden>(listaProductDto);

            var result = await _listaProductoOrdenServices.AddProductosOrdenes(objProducto);

            if (result != null)
                return Ok(result);
            else
                return BadRequest(result);
        }

        // PUT api/<ListaProductoOrdenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ListaProductoOrdenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
