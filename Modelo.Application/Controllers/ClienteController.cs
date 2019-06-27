using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Entities;
using Modelo.Service.Services;
using Modelo.Service.Validators;

namespace Modelo.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/Cliente")]
 
    public class ClienteController : Controller
    {
        private BaseService<Cliente> service = new BaseService<Cliente>();
        /// <summary>
        /// Recebe dados de usuario
        /// </summary>
        /// <param name="item">Dados do cliente</param>
        /// <returns>Objeto contendo dados do usuario.</returns>
        [HttpPost("Insere/{item}")]
        public IActionResult Post([FromBody] Cliente item)
        {
            try
            {
                service.Post<ClienteValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody] Cliente item)
        {
            try
            {
                service.Put<ClienteValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Busca todos os Clientes
        /// </summary>
        /// <returns>Objeto contendo Todos os Clientes.</returns>
        [HttpGet("BuscaTodos")]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Recebe Identificador de Cliente
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns>Objeto contendo dados do Cliente.</returns>
        [HttpGet("ObtemUsuario/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}