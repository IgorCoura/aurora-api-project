using Aurora.Domain.Interfaces;
using Aurora.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aurora.Application.Controllers
{
    [Route("api/PpePossession")]
    [ApiController]
    public class PpePossessionController : Controller
    {
        private readonly IServicePpePossession _servicePpePossession;

        public PpePossessionController(IServicePpePossession servicePpePossession)
        {
            _servicePpePossession = servicePpePossession;
        }

        [HttpPost]
        public IActionResult Register([FromBody]CreatePpePossessionModel ppePossessionModel)
        {
            try
            {
                var ppePossession = _servicePpePossession.Insert(ppePossessionModel);
                return Ok(ppePossession);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult RecoverAll()
        {
            try{
                var ppePossession = _servicePpePossession.RecoverAll();
                return Ok(ppePossession);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] int id)
        {
            try
            {
                var ppePossession = _servicePpePossession.RecoverById(id);
                return Ok(ppePossession);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remove([FromRoute] int id)
        {
            try
            {
                _servicePpePossession.Delete(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] CreatePpePossessionModel ppePossessionModel)
        {
            try
            {
                var ppePossession = _servicePpePossession.Update(id, ppePossessionModel);
                return Ok(ppePossession);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
