using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.ClienteServices;
using System.Collections.Generic;
using Web.ViewModel;

namespace Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteServices _clientesServices;
        private readonly IMapper _mapper;
        public ClientesController(IClienteServices clientesServices, IMapper mapper)
        {
            _clientesServices = clientesServices;
            _mapper = mapper;
        }
        // GET: ClientesController
        public ActionResult Index()
        {

            var clientList =  _clientesServices.GetClientesList();

            clientList.Wait();

            var datosVm = _mapper.Map<IEnumerable<ClientesDto>>(clientList.Result);
           
            return View(datosVm);
        }

        [HttpPost]
        public JsonResult GetDataTableCliente()
    {
            var clientList = _clientesServices.GetClientesList();

            clientList.Wait();

            var datosVm = _mapper.Map<IEnumerable<ClientesDto>>(clientList.Result);

            return Json(new { data = datosVm });
        }

    }
}
