using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SAAS.Model;
using SAAS.Service;
namespace SAAS.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EspecialidadeController : ControllerBase
    {
        // GET api/Especialidade
        [HttpGet]
        public ActionResult<IEnumerable<Especialidade>> Get()
        {
            var ret = EspecialidadeService.SelecionarTodasEspecialidades();
            if (ret.Ok) return Ok(ret.ListaObj);
            else return BadRequest(ret.MensagemProc);
        }
    }
}