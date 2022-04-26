using ApiProject.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;
using Services.ProductoServices;
using System;
using System.Threading.Tasks;

namespace ApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoServices _productoServices;
        private readonly IMapper _mapper;
        public ProductosController(IProductoServices productoServices, IMapper mapper)
        {
            _productoServices = productoServices;
            _mapper = mapper;
        }


        // GET: api/<ProductosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var productList = await _productoServices.GetProductosList();

            var datosVm = _mapper.Map<ProductosDto>(productList);

            return Ok(datosVm);
        }

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var productObj = await _productoServices.GetProductos(id);

            var datosVm = _mapper.Map<ProductosDto>(productObj);

            return Ok(datosVm);
        }

        // POST api/<ProductosController>
        [HttpPost]
        public async Task<IActionResult> Post(ProductosDto productDto)
        {
            var objProduct = _mapper.Map<Productos>(productDto);

            var result = await _productoServices.AddProductos(objProduct);

            if (result.IdProducto > 0)
                return Ok(result);
            else
                return BadRequest(result);

        }

        // PUT api/<ProductosController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(ProductosDto productDto)
        {
            var objProduct = _mapper.Map<Productos>(productDto);

            var result = await _productoServices.UpdateProductos(objProduct);

            if (result != null)
                return Ok(result);
            else
                return BadRequest(result);
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _productoServices.DeleteProductosAsync(id);
                return Ok();
            }
            catch (Exception ex) { return BadRequest(ex); }
        }
    }
}
