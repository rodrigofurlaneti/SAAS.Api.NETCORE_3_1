using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SAAS.Model;
using SAAS.Service;
namespace SAAS.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicoController : ControllerBase
    {
        // GET medico
        [HttpGet]
        public ActionResult<IEnumerable<Medico>> Get()
        {
            var ret = MedicoService.SelecionarTodosMedicos();
            if (ret.Ok) return Ok(ret.ListaObj);
            else return BadRequest(ret.MensagemProc);
        }
    }
}