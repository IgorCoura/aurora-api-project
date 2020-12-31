using Microsoft.AspNetCore.Mvc;
using Aurora.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aurora.Domain.Interfaces;

namespace Aurora.Application.Controllers
{
    [Route("api/ppe")]
    [ApiController]
    public class PersonalProtectiveEquipment : Controller
    {
        private readonly IServicePpe _servicePpe;

        public PersonalProtectiveEquipment(IServicePpe servicePpe)
        {
            _servicePpe = servicePpe;
        }

        [HttpPost]
        public IActionResult Register([FromBody] CreatePpeModel ppeModel)
        {
            try
            {
                var ppe = _servicePpe.Insert(ppeModel);

                return Created($"/api/ppe/{ppe?.Id}", ppe?.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdatePpeModel ppeModel)
        {
            try
            {
                var ppe = _servicePpe.Update(id, ppeModel);

                return NoContent();
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
                _servicePpe.Delete(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult RecoverAll()
        {
            try
            {
                var ppe = _servicePpe.RecoverAll();
                return Ok(ppe);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] int id)
        {
            try
            {
                var ppe = _servicePpe.RecoverById(id);
                return Ok(ppe);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
